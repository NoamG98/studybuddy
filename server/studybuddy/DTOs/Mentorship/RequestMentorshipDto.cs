namespace StudyBuddy.DTOs.Mentorship
{
    public class RequestMentorshipDto
    {
        public Guid MentorId { get; set; }
        public Guid MenteeId { get; set; }
        public required string Message { get; set; }
    }
}
