using System;

namespace StudyBuddy.Models
{
    public class ChatMessage
    {
        public Guid Id { get; set; } = Guid.NewGuid();


        public Guid SenderId { get; set; }
        public User Sender { get; set; } = null!;


        public Guid ReceiverId { get; set; }
        public User Receiver { get; set; } = null!;

        public required string Content { get; set; }
        public DateTime SentAt { get; set; } = DateTime.UtcNow;
    }
}
