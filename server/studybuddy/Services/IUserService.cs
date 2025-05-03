using StudyBuddy.DTOs.User;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudyBuddy.Services
{
    public interface IUserService
    {
        Task<UserResponse> GetByIdAsync(Guid id);
        Task<List<UserResponse>> SearchUsersAsync(string? query, string? country, string? field);
        Task<UserResponse> CreateUserAsync(UserCreateRequest request);
        Task<List<UserResponse>> GetAllUsersAsync();

        Task UpdateUserAsync(Guid id, UpdateUserRequest request);
        Task<bool> DeleteUserAsync(Guid id);
    }
}
