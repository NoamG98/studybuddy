using System;
using System.Security.Cryptography;
using System.Text;

namespace StudyBuddy.Helpers
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {

            using var sha = SHA256.Create();
            var hashed = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hashed);
        }

        public static bool VerifyPassword(string password, string storedHash)
        {
            using var sha = SHA256.Create();
            var computed = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(computed) == storedHash;
        }
    }
}
