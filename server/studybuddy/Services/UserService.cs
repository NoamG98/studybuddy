using StudyBuddy.DTOs.User;
using StudyBuddy.Models;
using StudyBuddy.Repositories;
using StudyBuddy.Helpers; // JwtHelper
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyBuddy.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly JwtHelper _jwtHelper;

        public UserService(IUserRepository userRepository, JwtHelper jwtHelper)
        {
            _userRepository = userRepository;
            _jwtHelper = jwtHelper;
        }

        public async Task<UserResponse> GetByIdAsync(Guid id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null) throw new Exception("User not found");

            return new UserResponse
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Role = user.Role,
                Country = user.Country,
                City = user.City,
                Gender = user.Gender,
                DateOfBirth = user.DateOfBirth,
                StudyField = user.StudyField,
                AvatarUrl = user.AvatarUrl
            };
        }

        public async Task<List<UserResponse>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return users.Select(u => new UserResponse
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Email,
                Role = u.Role,
                Country = u.Country,
                City = u.City,
                Gender = u.Gender,
                DateOfBirth = u.DateOfBirth,
                StudyField = u.StudyField,
                AvatarUrl = u.AvatarUrl
            }).ToList();
        }

        public async Task<List<UserResponse>> SearchUsersAsync(string? query, string? country, string? field)
        {
            var users = await _userRepository.SearchUsersAsync(query, country, field);
            return users.Select(u => new UserResponse
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Email,
                Role = u.Role,
                Country = u.Country,
                City = u.City,
                Gender = u.Gender,
                DateOfBirth = u.DateOfBirth,
                StudyField = u.StudyField,
                AvatarUrl = u.AvatarUrl
            }).ToList();
        }

        public async Task<UserResponse> CreateUserAsync(UserCreateRequest request)
        {
            var existing = await _userRepository.GetByEmailAsync(request.Email);
            if (existing != null)
                throw new Exception("User with this email already exists");

            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                PasswordHash = _jwtHelper.HashPassword(request.Password),
                Role = request.Role,
                Country = request.Country,
                City = request.City,
                Gender = request.Gender,
                DateOfBirth = request.DateOfBirth,
                StudyField = request.StudyField,
                AvatarUrl = request.AvatarUrl
            };

            await _userRepository.AddAsync(user);
            await _userRepository.SaveChangesAsync();

            return new UserResponse
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Role = user.Role,
                Country = user.Country,
                City = user.City,
                Gender = user.Gender,
                DateOfBirth = user.DateOfBirth,
                StudyField = user.StudyField,
                AvatarUrl = user.AvatarUrl
            };
        }

        public async Task UpdateUserAsync(Guid id, UpdateUserRequest request)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null) throw new Exception("User not found");

            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.Email = request.Email;
            if (!string.IsNullOrWhiteSpace(request.Password))
                user.PasswordHash = _jwtHelper.HashPassword(request.Password);
            user.Country = request.Country;
            user.City = request.City;
            user.StudyField = request.StudyField;
            user.Gender = request.Gender;
            user.DateOfBirth = request.DateOfBirth;
            user.AvatarUrl = request.AvatarUrl;

            await _userRepository.UpdateAsync(user);
            await _userRepository.SaveChangesAsync();
        }

        public async Task<bool> DeleteUserAsync(Guid id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null) return false;

            await _userRepository.DeleteAsync(user);
            await _userRepository.SaveChangesAsync();
            return true;
        }
    }
}
