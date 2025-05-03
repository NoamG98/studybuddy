using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace StudyBuddy.Helpers
{
    public class JwtHelper
    {
        private readonly IConfiguration _configuration;
        private const int SaltSize = 16; // bytes
        private const int KeySize = 32;  // bytes
        private const int Iterations = 100_000;

        public JwtHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateToken(string userId, string email, string role)
        {
            var secret = _configuration["JwtSettings:SecretKey"];
            if (string.IsNullOrWhiteSpace(secret))
                throw new Exception("Missing JWT secret in configuration");

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userId),
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Role, role),
                new Claim("sub", userId)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(
                    double.Parse(_configuration["JwtSettings:DurationMinutes"] ?? "60")
                ),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[64];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        /// <summary>
        /// Hashes the given password using PBKDF2 (Rfc2898) with a random salt.
        /// Returns a base64 string containing: [version(1b)] + [salt] + [hash].
        /// </summary>
        public string HashPassword(string password)
        {
            // 1-byte format marker + salt + hash
            var salt = new byte[SaltSize];
            using (var rng = RandomNumberGenerator.Create())
                rng.GetBytes(salt);

            using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
            var hash = pbkdf2.GetBytes(KeySize);

            var result = new byte[1 + SaltSize + KeySize];
            result[0] = 0x01; // version
            Buffer.BlockCopy(salt, 0, result, 1, SaltSize);
            Buffer.BlockCopy(hash, 0, result, 1 + SaltSize, KeySize);

            return Convert.ToBase64String(result);
        }

        /// <summary>
        /// Verifies a password against the stored hash (base64 string from HashPassword).
        /// </summary>
        public bool VerifyPassword(string password, string storedHash)
        {
            var decoded = Convert.FromBase64String(storedHash);
            if (decoded.Length != 1 + SaltSize + KeySize || decoded[0] != 0x01)
                return false; // invalid format

            var salt = new byte[SaltSize];
            Buffer.BlockCopy(decoded, 1, salt, 0, SaltSize);
            var hash = new byte[KeySize];
            Buffer.BlockCopy(decoded, 1 + SaltSize, hash, 0, KeySize);

            using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
            var computed = pbkdf2.GetBytes(KeySize);

            return CryptographicOperations.FixedTimeEquals(computed, hash);
        }
    }
}