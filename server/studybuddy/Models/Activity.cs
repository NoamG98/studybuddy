using System;

namespace StudyBuddy.Models
{
    public class Activity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public required User User { get; set; }
        public required string ActionType { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public string? Description { get; set; }
    }
}