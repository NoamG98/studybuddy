using StudyBuddy.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudyBuddy.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetByEmailAsync(string email);
        Task<User?> GetByIdAsync(Guid id);
        Task<List<User>> GetAllAsync();
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task<List<User>> SearchUsersAsync(string? query, string? country, string? field);
        Task SaveChangesAsync();
        Task DeleteAsync(User user);
        Task<User?> GetByRefreshTokenAsync(string refreshToken);
    }
}
