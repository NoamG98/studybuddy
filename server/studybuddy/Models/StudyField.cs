using System;

namespace StudyBuddy.Models
{
    public class StudyField
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Name { get; set; }
    }
}