using StudyBuddy.Repositories;
using System;
using System.Threading.Tasks;

namespace StudyBuddy.Services
{
    public class LikeService : ILikeService
    {
        private readonly ILikeRepository _likeRepo;
        public LikeService(ILikeRepository likeRepo) => _likeRepo = likeRepo;

        public async Task<bool> AddLikeAsync(Guid userId, Guid postId)
        {
            if (await _likeRepo.ExistsAsync(userId, postId))
                return false;
            await _likeRepo.AddAsync(userId, postId);
            return true;
        }

        public Task RemoveLikeAsync(Guid userId, Guid postId)
            => _likeRepo.RemoveAsync(userId, postId);

        public Task<int> GetLikeCountAsync(Guid postId)
            => _likeRepo.CountAsync(postId);

        public Task<bool> ExistsAsync(Guid userId, Guid postId)
            => _likeRepo.ExistsAsync(userId, postId);
    }
}