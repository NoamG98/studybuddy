using Microsoft.EntityFrameworkCore;
using StudyBuddy.Data;
using StudyBuddy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyBuddy.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDbContext _ctx;
        public CommentRepository(ApplicationDbContext ctx) => _ctx = ctx;

        public async Task AddAsync(Comment comment)
            => await _ctx.Comments.AddAsync(comment);

        public async Task<List<Comment>> GetByPostIdAsync(Guid postId)
            => await _ctx.Comments
                         .Where(c => c.PostId == postId)
                         .OrderBy(c => c.CreatedAt)
                         .ToListAsync();

        public async Task SaveChangesAsync()
            => await _ctx.SaveChangesAsync();
    }
}
