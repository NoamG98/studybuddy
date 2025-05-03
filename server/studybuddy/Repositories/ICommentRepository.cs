using StudyBuddy.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudyBuddy.Repositories
{
    public interface ICommentRepository
    {
        Task AddAsync(Comment comment);
        Task<List<Comment>> GetByPostIdAsync(Guid postId);
        Task SaveChangesAsync();
    }
}
