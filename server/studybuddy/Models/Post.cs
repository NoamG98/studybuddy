// Models/Post.cs
using System;
using System.Collections.Generic;

namespace StudyBuddy.Models
{
    public class Post
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Guid UserId { get; set; }
        public required User User { get; set; } = default!;
        public string? ImageUrl { get; set; }
        public ICollection<Like> Likes { get; set; } = new List<Like>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
