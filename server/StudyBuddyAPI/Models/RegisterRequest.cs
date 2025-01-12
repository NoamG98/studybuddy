using System;
using System.ComponentModel.DataAnnotations;

namespace StudyBuddyAPI.Models
{
    /// <summary>
    /// Represents a request to register a new user.
    /// </summary>
    public class RegisterRequest
    {
        /// <summary>
        /// The first name of the user.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// The last name of the user.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// The email address of the user.
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// The password for the user account.
        /// </summary>
        [Required]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
        public string Password { get; set; } = string.Empty;

        /// <summary>
        /// The country of the user.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Country { get; set; } = string.Empty;

        /// <summary>
        /// The birth date of the user.
        /// </summary>
        [Required]
        public DateTime Birthday { get; set; }
    }
}
