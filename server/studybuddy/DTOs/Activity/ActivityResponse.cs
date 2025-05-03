namespace StudyBuddy.DTOs.Activity
{
    public class ActivityResponse
    {
        public Guid Id { get; set; }
        public required string ActionType { get; set; }
        public DateTime Timestamp { get; set; }
        public required string Description { get; set; }
    }
}
