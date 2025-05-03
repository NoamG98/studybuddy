namespace StudyBuddy.DTOs.Mentorship
{
    public class MentorshipResponseDto
    {
        public Guid Id { get; set; }
        public Guid MentorId { get; set; }
        public Guid MenteeId { get; set; }
        public required string Message { get; set; }
        public DateTime RequestedAt { get; set; }
    }
}
