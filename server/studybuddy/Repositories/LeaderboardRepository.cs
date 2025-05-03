using Microsoft.EntityFrameworkCore;
using StudyBuddy.Data;
using StudyBuddy.Models;

namespace StudyBuddy.Repositories
{
    public class LeaderboardRepository : ILeaderboardRepository
    {
        private readonly ApplicationDbContext _context;

        public LeaderboardRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<LeaderboardEntry>> GetTopEntriesAsync()
        {
            return await _context.LeaderboardEntries
                .Include(e => e.User)
                .OrderByDescending(e => e.Points)
                .Take(10)
                .ToListAsync();
        }
    }
}