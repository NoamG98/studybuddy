using System;
using System.Collections.Generic;

namespace StudyBuddyAPI.Models
{
    /// <summary>
    /// Represents a post created by a user.
    /// </summary>
    public class Post
    {
        /// <summary>
        /// Unique identifier for the post.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The content of the post.
        /// </summary>
        public string Content { get; set; } = null!;

        /// <summary>
        /// The email of the user who created the post.
        /// </summary>
        public string UserEmail { get; set; } = null!;

        /// <summary>
        /// The user who created the post.
        /// </summary>
        public User User { get; set; } = null!;

        /// <summary>
        /// The timestamp when the post was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The collection of likes associated with the post.
        /// </summary>
        public ICollection<Like> Likes { get; set; } = new List<Like>();
    }
}
