using StudyBuddy.DTOs.Auth;
using StudyBuddy.Services;

namespace StudyBuddy.Services
{
    public interface IAuthService
    {
        Task<ServiceResponse<AuthResponse>> LoginAsync(LoginRequest request);
        Task<ServiceResponse<AuthResponse>> RegisterAsync(RegisterRequest request);
        Task<ServiceResponse<AuthResponse>> RefreshTokenAsync(string refreshToken);
    }
}