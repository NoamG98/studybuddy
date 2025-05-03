using StudyBuddy.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudyBuddy.Repositories
{
    public interface IPostRepository
    {
        Task<List<Post>> GetAllAsync();
        Task<Post?> GetByIdAsync(Guid id);

        Task<List<Post>> GetAllWithIncludesAsync();
        Task<Post?> GetByIdWithIncludesAsync(Guid id);

        Task AddAsync(Post post);
        Task UpdateAsync(Post post);
        Task DeleteAsync(Post post);
        Task SaveChangesAsync();
    }
}
