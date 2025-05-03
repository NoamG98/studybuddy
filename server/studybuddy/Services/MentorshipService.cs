using StudyBuddy.DTOs.Mentorship;
using StudyBuddy.Repositories;

namespace StudyBuddy.Services
{
    public class MentorshipService : IMentorshipService
    {
        private readonly IMentorshipRepository _mentorshipRepository;

        public MentorshipService(IMentorshipRepository mentorshipRepository)
        {
            _mentorshipRepository = mentorshipRepository;
        }

        public async Task<List<MentorshipResponseDto>> GetAllMentorshipsAsync()
        {
            return await _mentorshipRepository.GetAllMentorshipsAsync();
        }

        public async Task<MentorshipResponseDto> RequestMentorshipAsync(RequestMentorshipDto request)
        {
            return await _mentorshipRepository.CreateMentorshipRequestAsync(request);
        }
    }
}