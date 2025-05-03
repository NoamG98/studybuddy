using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace StudyBuddy.Models
{
    public class Community
    {
        public Guid Id { get; set; } = Guid.NewGuid();


        public Guid StudyFieldId { get; set; }
        public StudyField StudyField { get; set; } = null!;


        public Guid CountryId { get; set; }
        public Country Country { get; set; } = null!;

        public required string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<User> Members { get; set; } = new List<User>();
    }
}
