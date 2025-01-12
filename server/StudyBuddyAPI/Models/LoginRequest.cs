namespace StudyBuddyAPI.Models
{
    /// <summary>
    /// Represents a login request with email and password.
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// The email address of the user attempting to log in.
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// The password of the user attempting to log in.
        /// </summary>
        public string Password { get; set; } = string.Empty;
    }
}
