namespace StudyBuddy.DTOs.Activity
{
    public class ActivityCreateRequest
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid UserId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string ActionType { get; set; } = string.Empty;
    }
}