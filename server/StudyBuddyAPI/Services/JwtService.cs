using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace StudyBuddyAPI.Services
{
    /// <summary>
    /// Service for generating and validating JWT tokens.
    /// </summary>
    public class JwtService
    {
        private readonly string _secretKey;
        private readonly string _issuer;
        private readonly string _audience;

        public JwtService(string secretKey, string issuer, string audience)
        {
            _secretKey = secretKey;
            _issuer = issuer;
            _audience = audience;
        }

        /// <summary>
        /// Generates a JWT token for the specified user email and optional additional claims.
        /// </summary>
        /// <param name="userEmail">The email of the user.</param>
        /// <param name="additionalClaims">Optional additional claims to include in the token.</param>
        /// <returns>A signed JWT token.</returns>
        public string GenerateToken(string userEmail, List<Claim>? additionalClaims = null)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, userEmail),
                new Claim(JwtRegisteredClaimNames.Email, userEmail),
            };

            if (additionalClaims != null)
            {
                claims.AddRange(additionalClaims);
            }

            var token = new JwtSecurityToken(
                issuer: _issuer,
                audience: _audience,
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
