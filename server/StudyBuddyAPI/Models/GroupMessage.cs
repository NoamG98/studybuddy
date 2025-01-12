namespace StudyBuddyAPI.Models
{
    /// <summary>
    /// Represents a message within a study group.
    /// </summary>
    public class GroupMessage
    {
        /// <summary>
        /// Unique identifier for the message.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identifier of the group this message belongs to.
        /// </summary>
        public int GroupId { get; set; }

        /// <summary>
        /// The study group associated with this message.
        /// </summary>
        public required StudyGroup Group { get; set; }

        /// <summary>
        /// Email of the sender.
        /// </summary>
        public string SenderEmail { get; set; } = null!; // Updated to match User.Email

        /// <summary>
        /// The user who sent the message.
        /// </summary>
        public required User Sender { get; set; }

        /// <summary>
        /// The content of the message.
        /// </summary>
        public required string Content { get; set; }

        /// <summary>
        /// The time when the message was sent.
        /// </summary>
        public DateTime SentAt { get; set; } = DateTime.UtcNow;
    }
}
