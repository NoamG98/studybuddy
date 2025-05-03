using Microsoft.EntityFrameworkCore;
using StudyBuddy.Data;
using StudyBuddy.DTOs.Mentorship;
using StudyBuddy.Models;

namespace StudyBuddy.Repositories
{
    public class MentorshipRepository : IMentorshipRepository
    {
        private readonly ApplicationDbContext _context;

        public MentorshipRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<MentorshipResponseDto>> GetAllMentorshipsAsync()
        {
            return await _context.Mentorships
                .Include(m => m.Mentor)
                .Include(m => m.Mentee)
                .Select(m => new MentorshipResponseDto
                {
                    Id = m.Id,
                    MentorId = m.MentorId,
                    MenteeId = m.MenteeId,
                    Message = m.Message,
                    RequestedAt = m.RequestedAt
                })
                .ToListAsync();
        }

        public async Task<MentorshipResponseDto> CreateMentorshipRequestAsync(RequestMentorshipDto request)
        {
            var mentorship = new Mentorship
            {
                Id = Guid.NewGuid(),
                MentorId = request.MentorId,
                MenteeId = request.MenteeId,
                Message = request.Message,
                RequestedAt = DateTime.UtcNow
            };

            _context.Mentorships.Add(mentorship);
            await _context.SaveChangesAsync();

            return new MentorshipResponseDto
            {
                Id = mentorship.Id,
                MentorId = mentorship.MentorId,
                MenteeId = mentorship.MenteeId,
                Message = mentorship.Message,
                RequestedAt = mentorship.RequestedAt
            };
        }
    }
}