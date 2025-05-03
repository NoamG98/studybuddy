using StudyBuddy.DTOs.Mentorship;


namespace StudyBuddy.Repositories
{
    public interface IMentorshipRepository
    {
        Task<List<MentorshipResponseDto>> GetAllMentorshipsAsync();
        Task<MentorshipResponseDto> CreateMentorshipRequestAsync(RequestMentorshipDto request);
    }
}