using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudyBuddyAPI.DTOs;
using StudyBuddyAPI.Data;
using StudyBuddyAPI.Models;
using StudyBuddyAPI.Services;
using System.Security.Claims;

namespace StudyBuddyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly StudyBuddyDbContext _context;
        private readonly EmailService _emailService;
        private readonly JwtService _jwtService;

        public UsersController(StudyBuddyDbContext context, EmailService emailService, JwtService jwtService)
        {
            _context = context;
            _emailService = emailService;
            _jwtService = jwtService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingUser = await _context.Users.SingleOrDefaultAsync(u => u.Email == request.Email);

            if (existingUser != null)
            {
                return BadRequest(new { message = "Email is already registered" });
            }

            var newUser = new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password),
                Country = request.Country,
                BirthDate = request.Birthday
            };

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return Ok(new { message = "User registered successfully!" });
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = _context.Users.SingleOrDefault(u => u.Email == request.Email);

            if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
            {
                return Unauthorized(new { message = "Invalid credentials. Please try again." });
            }

            // Create claims for JWT
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}")
            };

            // Generate JWT using injected JwtService
            var token = _jwtService.GenerateToken(user.Email, claims);

            HttpContext.Response.Cookies.Append("user_session", user.Email, new CookieOptions
            {
                HttpOnly = true,
                Secure = false,
                SameSite = SameSiteMode.Strict
            });

            return Ok(new
            {
                message = "Login successful!",
                token,
                user = new
                {
                    user.FirstName,
                    user.LastName,
                    user.Email,
                    user.Country,
                    user.BirthDate
                }
            });
        }

        [HttpPost("updateProfilePicture")]
        public async Task<IActionResult> UpdateProfilePicture([FromBody] UpdateProfilePictureRequest request)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Email == request.Email);
            if (user == null)
            {
                return NotFound(new { message = "User not found" });
            }

            user.ProfilePicture = request.ProfilePictureUrl;
            await _context.SaveChangesAsync();

            return Ok(new { message = "Profile picture updated successfully!" });
        }

        [HttpGet("currentProfilePicture")]
        public IActionResult GetCurrentProfilePicture([FromQuery] string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return BadRequest(new { message = "Email is required" });
            }

            var user = _context.Users.SingleOrDefault(u => u.Email == email);
            if (user == null)
            {
                return NotFound(new { message = "User not found" });
            }

            return Ok(new
            {
                profilePictureUrl = user.ProfilePicture,
                firstName = user.FirstName,
                lastName = user.LastName
            });
        }

        [HttpGet("current")]
        public IActionResult GetCurrentUser()
        {
            var email = HttpContext.Request.Cookies["user_session"];
            if (string.IsNullOrEmpty(email))
            {
                return Unauthorized(new { message = "User is not authenticated" });
            }

            var user = _context.Users.SingleOrDefault(u => u.Email == email);
            if (user == null)
            {
                return NotFound(new { message = "User not found" });
            }

            return Ok(new
            {
                user.Email,
                user.FirstName,
                user.LastName,
                user.ProfilePicture
            });
        }
    }
}
