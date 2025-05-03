using StudyBuddy.DTOs.Auth;
using StudyBuddy.Helpers;
using StudyBuddy.Models;
using StudyBuddy.Repositories;
using System.Threading.Tasks;

namespace StudyBuddy.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly JwtHelper _jwtHelper;
        private readonly EmailService _emailService;

        public AuthService(IUserRepository userRepository, JwtHelper jwtHelper, EmailService emailService)
        {
            _userRepository = userRepository;
            _jwtHelper = jwtHelper;
            _emailService = emailService;
        }

        public async Task<ServiceResponse<AuthResponse>> LoginAsync(LoginRequest request)
        {
            var user = await _userRepository.GetByEmailAsync(request.Email);
            if (user == null || !PasswordHasher.VerifyPassword(request.Password, user.PasswordHash))
            {
                return new ServiceResponse<AuthResponse> { Success = false, Message = "Invalid email or password" };
            }

            var token = _jwtHelper.GenerateToken(user.Id.ToString(), user.Email, user.Role);
            var refreshToken = _jwtHelper.GenerateRefreshToken();

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiry = DateTime.UtcNow.AddDays(7);
            await _userRepository.UpdateAsync(user);
            await _userRepository.SaveChangesAsync();

            return new ServiceResponse<AuthResponse>
            {
                Data = new AuthResponse
                {
                    Token = token,
                    RefreshToken = refreshToken,
                    Role = user.Role
                }
            };
        }

        public async Task<ServiceResponse<AuthResponse>> RegisterAsync(RegisterRequest request)
        {
            var existingUser = await _userRepository.GetByEmailAsync(request.Email);
            if (existingUser != null)
            {
                return new ServiceResponse<AuthResponse> { Success = false, Message = "Email already exists" };
            }

            var newUser = new User
            {
                Id = Guid.NewGuid(),
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                PasswordHash = PasswordHasher.HashPassword(request.Password),
                Role = request.Role,
                Country = request.Country,
                City = request.City,
                Gender = request.Gender,
                DateOfBirth = request.DateOfBirth,
                StudyField = request.StudyField,
                AvatarUrl = request.AvatarUrl,
                RefreshToken = _jwtHelper.GenerateRefreshToken(),
                RefreshTokenExpiry = DateTime.UtcNow.AddDays(7)
            };

            await _userRepository.AddAsync(newUser);
            await _userRepository.SaveChangesAsync();

            var token = _jwtHelper.GenerateToken(newUser.Id.ToString(), newUser.Email, newUser.Role);

            return new ServiceResponse<AuthResponse>
            {
                Data = new AuthResponse
                {
                    Token = token,
                    RefreshToken = newUser.RefreshToken,
                    Role = newUser.Role
                }
            };
        }

        public async Task<ServiceResponse<AuthResponse>> RefreshTokenAsync(string refreshToken)
        {
            var user = await _userRepository.GetByRefreshTokenAsync(refreshToken);
            if (user == null || user.RefreshTokenExpiry < DateTime.UtcNow)
            {
                return new ServiceResponse<AuthResponse> { Success = false, Message = "Invalid or expired refresh token" };
            }

            var newAccessToken = _jwtHelper.GenerateToken(user.Id.ToString(), user.Email, user.Role);
            var newRefreshToken = _jwtHelper.GenerateRefreshToken();

            user.RefreshToken = newRefreshToken;
            user.RefreshTokenExpiry = DateTime.UtcNow.AddDays(7);
            await _userRepository.UpdateAsync(user);
            await _userRepository.SaveChangesAsync();

            return new ServiceResponse<AuthResponse>
            {
                Data = new AuthResponse
                {
                    Token = newAccessToken,
                    RefreshToken = newRefreshToken,
                    Role = user.Role
                }
            };
        }
    }
}