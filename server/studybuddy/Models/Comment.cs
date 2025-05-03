using System;

namespace StudyBuddy.Models
{
    public class Comment
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Guid PostId { get; set; }
        public required Post Post { get; set; } = default!; 

        public Guid UserId { get; set; }
        public required User User { get; set; } = default!;  
    }
}
