using StudyBuddy.DTOs.Mentorship;

namespace StudyBuddy.Services
{
    public interface IMentorshipService
    {
        Task<List<MentorshipResponseDto>> GetAllMentorshipsAsync();
        Task<MentorshipResponseDto> RequestMentorshipAsync(RequestMentorshipDto request);
    }
}
