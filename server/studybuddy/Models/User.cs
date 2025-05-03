using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyBuddy.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        public required string Email { get; set; }
        public required string PasswordHash { get; set; }

        public required string Role { get; set; } // student / graduate / employer
        public required string Country { get; set; }
        public required string City { get; set; }
        public string? StudyField { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? AvatarUrl { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Post> Posts { get; set; } = new List<Post>();
        public ICollection<Friendship> Friends { get; set; } = new List<Friendship>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
        public ICollection<Like> Likes { get; set; } = new List<Like>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        [ForeignKey("CommunityId")]
        public Community? Community { get; set; }
        public Guid? CommunityId { get; set; }

        public string? Location { get; set; }
        public string? Name => $"{FirstName} {LastName}";

        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiry { get; set; }
    }
}