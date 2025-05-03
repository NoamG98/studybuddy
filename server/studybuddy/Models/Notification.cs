namespace StudyBuddy.Models
{
    public class Notification
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Content { get; set; } = string.Empty;
        public Guid UserId { get; set; }
        public User User { get; set; } = default!;
        public string Type { get; set; } = string.Empty;
        public string? ActionUrl { get; set; }
        public bool IsRead { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}