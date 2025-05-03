using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyBuddy.Models
{
    public class Mentorship
    {
        public Guid Id { get; set; } = Guid.NewGuid();


        public Guid MentorId { get; set; }
        public User Mentor { get; set; } = null!;

 
        public Guid MenteeId { get; set; }
        public User Mentee { get; set; } = null!;


        public DateTime RequestedAt { get; set; } = DateTime.UtcNow;
        public string Message { get; set; } = string.Empty;

        public DateTime StartDate { get; set; } = DateTime.UtcNow;
        public string Subject { get; set; } = string.Empty;
    }
}