namespace StudyBuddy.DTOs.Mentorship
{
    public class RequestMentorshipRequest
    {
        public Guid MentorId { get; set; }
        public Guid MenteeId { get; set; }
        public required string Message { get; set; }
    }
}
