using System.ComponentModel.DataAnnotations;

namespace StudyBuddyAPI.DTOs
{
    /// <summary>
    /// Represents a request to update the user's profile picture.
    /// </summary>
    public class UpdateProfilePictureRequest
    {
        /// <summary>
        /// The email of the user whose profile picture is being updated.
        /// </summary>
        [Required]
        public string Email { get; set; } = null!;

        /// <summary>
        /// The URL of the new profile picture.
        /// </summary>
        [Required]
        public string ProfilePictureUrl { get; set; } = null!;
    }
}
