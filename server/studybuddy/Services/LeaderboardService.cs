using StudyBuddy.DTOs.Leaderboard;
using StudyBuddy.Models;
using StudyBuddy.Repositories;

namespace StudyBuddy.Services
{
    public class LeaderboardService : ILeaderboardService
    {
        private readonly ILeaderboardRepository _leaderboardRepository;

        public LeaderboardService(ILeaderboardRepository leaderboardRepository)
        {
            _leaderboardRepository = leaderboardRepository;
        }

        public async Task<ServiceResponse<List<LeaderboardEntryResponse>>> GetLeaderboardAsync()
        {
            var entries = await _leaderboardRepository.GetTopEntriesAsync();

            return new ServiceResponse<List<LeaderboardEntryResponse>>
            {
                Data = entries.Select(e => new LeaderboardEntryResponse
                {
                    Id = e.Id,
                    UserId = e.UserId,
                    UserName = e.User!.FullName, 
                    Points = e.Points
                }).ToList()
            };
        }
    }
}