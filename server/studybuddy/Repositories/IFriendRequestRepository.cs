using StudyBuddy.Models;

namespace StudyBuddy.Repositories
{
    public interface IFriendRequestRepository
    {
        Task<FriendRequest?> GetByIdAsync(Guid id);
        Task AddAsync(FriendRequest entity);
        Task UpdateAsync(FriendRequest entity);
        Task DeleteAsync(FriendRequest entity);
        Task<IEnumerable<FriendRequest>> GetSentAsync(Guid fromUserId);
        Task<IEnumerable<FriendRequest>> GetReceivedAsync(Guid toUserId);
        Task SaveChangesAsync();
    }
}
