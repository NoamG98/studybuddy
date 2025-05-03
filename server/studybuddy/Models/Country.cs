using System;

namespace StudyBuddy.Models
{
    public class Country
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Name { get; set; }
    }
}
