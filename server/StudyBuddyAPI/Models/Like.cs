using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyBuddyAPI.Models
{
    /// <summary>
    /// Represents a like on a post by a user.
    /// </summary>
    public class Like
    {
        /// <summary>
        /// Unique identifier for the like.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The email of the user who liked the post.
        /// </summary>
        [Required]
        public string UserEmail { get; set; } = null!;

        /// <summary>
        /// The user who liked the post.
        /// </summary>
        [ForeignKey(nameof(UserEmail))]
        public User User { get; set; } = null!;

        /// <summary>
        /// The ID of the post that was liked.
        /// </summary>
        [Required]
        public int PostId { get; set; }

        /// <summary>
        /// The post that was liked.
        /// </summary>
        [ForeignKey(nameof(PostId))]
        public Post Post { get; set; } = null!;

        /// <summary>
        /// The timestamp of when the like was created.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
