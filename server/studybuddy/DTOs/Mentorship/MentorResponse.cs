namespace StudyBuddy.DTOs.Mentorship
{
    public class MentorResponse
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string ExpertiseField { get; set; }
        public required string Bio { get; set; }
    }
}
