using Microsoft.EntityFrameworkCore;
using StudyBuddy.Data;
using StudyBuddy.Models;
using System;
using System.Threading.Tasks;

namespace StudyBuddy.Repositories
{
    public class LikeRepository : ILikeRepository
    {
        private readonly ApplicationDbContext _context;

        public LikeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> ExistsAsync(Guid userId, Guid postId)
        {
            return await _context.Likes
                .AnyAsync(l => l.UserId == userId && l.PostId == postId);
        }

        public async Task AddAsync(Guid userId, Guid postId)
        {
            var user = await _context.Users.FindAsync(userId);
            var post = await _context.Posts.FindAsync(postId);

            if (user == null || post == null)
            {
                throw new InvalidOperationException("User or Post not found.");
            }

            var like = new Like
            {
                UserId = userId,
                PostId = postId,
                User = user,
                Post = post
            };

            _context.Likes.Add(like);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(Guid userId, Guid postId)
        {
            var like = await _context.Likes
                .FirstOrDefaultAsync(l => l.UserId == userId && l.PostId == postId);
            if (like != null)
            {
                _context.Likes.Remove(like);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<int> CountAsync(Guid postId)
        {
            return await _context.Likes
                .CountAsync(l => l.PostId == postId);
        }
    }
}
