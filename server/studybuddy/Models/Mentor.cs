using System;

namespace StudyBuddy.Models
{
    public class Mentor
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public required User User { get; set; }
        public required string ExpertiseField { get; set; }
        public required string Bio { get; set; }
    }
}