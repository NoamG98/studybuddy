using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudyBuddyAPI.Models
{
    /// <summary>
    /// Represents a user in the StudyBuddy system.
    /// </summary>
    public class User
    {
        /// <summary>
        /// The first name of the user.
        /// </summary>
        [Required]
        public string FirstName { get; set; } = null!;

        /// <summary>
        /// The last name of the user.
        /// </summary>
        [Required]
        public string LastName { get; set; } = null!;

        /// <summary>
        /// The unique email address of the user.
        /// </summary>
        [Key]
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        /// <summary>
        /// The hashed password for the user's account.
        /// </summary>
        [Required]
        public string PasswordHash { get; set; } = null!;

        /// <summary>
        /// The country of the user.
        /// </summary>
        [Required]
        public string Country { get; set; } = null!;

        /// <summary>
        /// The birth date of the user.
        /// </summary>
        [Required]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// The date and time when the user account was created.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// The profile picture URL of the user.
        /// </summary>
        public string? ProfilePicture { get; set; }

        /// <summary>
        /// The collection of study fields associated with the user.
        /// </summary>
        public ICollection<UserStudyField> UserStudyFields { get; set; } = new List<UserStudyField>();

        /// <summary>
        /// The collection of likes made by the user.
        /// </summary>
        public ICollection<Like> Likes { get; set; } = new List<Like>();

        /// <summary>
        /// The collection of study groups the user is a member of.
        /// </summary>
        public ICollection<StudyGroup> StudyGroups { get; set; } = new List<StudyGroup>();
    }
}
