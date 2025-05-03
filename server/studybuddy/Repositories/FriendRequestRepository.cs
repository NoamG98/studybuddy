using Microsoft.EntityFrameworkCore;
using StudyBuddy.Data;
using StudyBuddy.Models;

namespace StudyBuddy.Repositories
{
    public class FriendRequestRepository : IFriendRequestRepository
    {
        private readonly ApplicationDbContext _ctx;
        public FriendRequestRepository(ApplicationDbContext ctx) => _ctx = ctx;

        public async Task<FriendRequest?> GetByIdAsync(Guid id) =>
            await _ctx.FriendRequests.FindAsync(id);

        public async Task AddAsync(FriendRequest entity) =>
            await _ctx.FriendRequests.AddAsync(entity);

        public Task UpdateAsync(FriendRequest entity)
        {
            _ctx.FriendRequests.Update(entity);
            return Task.CompletedTask;
        }

        public Task DeleteAsync(FriendRequest entity)
        {
            _ctx.FriendRequests.Remove(entity);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<FriendRequest>> GetSentAsync(Guid fromUserId) =>
            await _ctx.FriendRequests
                .Where(r => r.FromUserId == fromUserId)
                .ToListAsync();

        public async Task<IEnumerable<FriendRequest>> GetReceivedAsync(Guid toUserId) =>
            await _ctx.FriendRequests
                .Where(r => r.ToUserId == toUserId)
                .ToListAsync();

        public async Task SaveChangesAsync() =>
            await _ctx.SaveChangesAsync();
    }
}
