using System;

namespace StudyBuddy.Models
{
    public class JobRecommendation
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string Company { get; set; }
        public required string Location { get; set; }
        public required string Field { get; set; }
        public DateTime PostedAt { get; set; } = DateTime.UtcNow;
    }
}