
using Microsoft.EntityFrameworkCore;
using StudyBuddy.Data;
using StudyBuddy.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudyBuddy.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly ApplicationDbContext _ctx;
        public PostRepository(ApplicationDbContext ctx) => _ctx = ctx;


        public Task<List<Post>> GetAllAsync() =>
            _ctx.Posts.ToListAsync();

        public Task<Post?> GetByIdAsync(Guid id) =>
            _ctx.Posts.FirstOrDefaultAsync(p => p.Id == id);

 
        public Task<List<Post>> GetAllWithIncludesAsync() =>
            _ctx.Posts
                .Include(p => p.User)
                .Include(p => p.Likes)
                .Include(p => p.Comments)
                    .ThenInclude(c => c.User)
                .ToListAsync();

        public Task<Post?> GetByIdWithIncludesAsync(Guid id) =>
            _ctx.Posts
                .Include(p => p.User)
                .Include(p => p.Likes)
                .Include(p => p.Comments)
                    .ThenInclude(c => c.User)
                .FirstOrDefaultAsync(p => p.Id == id);

        public async Task AddAsync(Post post)
        {
            await _ctx.Posts.AddAsync(post);
        }

        public async Task UpdateAsync(Post post)
        {
            _ctx.Posts.Update(post);
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(Post post)
        {
            _ctx.Posts.Remove(post);
            await Task.CompletedTask;
        }

        public async Task SaveChangesAsync()
        {
            await _ctx.SaveChangesAsync();
        }
    }
}
