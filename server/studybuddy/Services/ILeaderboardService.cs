using StudyBuddy.DTOs.Leaderboard;

namespace StudyBuddy.Services
{
    public interface ILeaderboardService
    {
        Task<ServiceResponse<List<LeaderboardEntryResponse>>> GetLeaderboardAsync();
    }
}