using StudyBuddy.Models;

namespace StudyBuddy.Repositories
{
    public interface ILeaderboardRepository
    {
        Task<List<LeaderboardEntry>> GetTopEntriesAsync();
    }
}