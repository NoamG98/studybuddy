namespace StudyBuddyAPI.Models
{
    /// <summary>
    /// Represents a direct message exchanged between two users.
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Unique identifier for the message.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The email of the user who sent the message.
        /// </summary>
        public string SenderEmail { get; set; } = null!;

        /// <summary>
        /// The user who sent the message.
        /// </summary>
        public User Sender { get; set; } = null!;

        /// <summary>
        /// The email of the user who received the message.
        /// </summary>
        public string ReceiverEmail { get; set; } = null!;

        /// <summary>
        /// The user who received the message.
        /// </summary>
        public User Receiver { get; set; } = null!;

        /// <summary>
        /// The content of the message.
        /// </summary>
        public string Content { get; set; } = null!;

        /// <summary>
        /// The timestamp when the message was sent.
        /// </summary>
        public DateTime SentAt { get; set; } = DateTime.UtcNow;
    }
}
