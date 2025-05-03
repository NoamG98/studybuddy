using System;
using System.Threading.Tasks;

namespace StudyBuddy.Repositories
{
    public interface ILikeRepository
    {
        Task<bool> ExistsAsync(Guid userId, Guid postId);
        Task AddAsync(Guid userId, Guid postId);
        Task RemoveAsync(Guid userId, Guid postId);
        Task<int> CountAsync(Guid postId);
    }
}