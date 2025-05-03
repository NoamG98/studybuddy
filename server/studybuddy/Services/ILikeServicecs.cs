using System;
using System.Threading.Tasks;

namespace StudyBuddy.Services
{
    public interface ILikeService
    {
        Task<bool> AddLikeAsync(Guid userId, Guid postId);
        Task RemoveLikeAsync(Guid userId, Guid postId);
        Task<int> GetLikeCountAsync(Guid postId);
        Task<bool> ExistsAsync(Guid userId, Guid postId);
    }
}
