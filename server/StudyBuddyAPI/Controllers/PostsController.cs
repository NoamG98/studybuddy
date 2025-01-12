using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudyBuddyAPI.Data;
using StudyBuddyAPI.Models;

namespace StudyBuddyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly StudyBuddyDbContext _context;

        public PostsController(StudyBuddyDbContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpPost("{postId}/like")]
        public async Task<IActionResult> LikePost(int postId)
        {
            var userEmail = User.Identity?.Name; // Get email from JWT
            if (string.IsNullOrEmpty(userEmail))
            {
                return Unauthorized(new { message = "User not logged in." });
            }

            var user = await _context.Users.SingleOrDefaultAsync(u => u.Email == userEmail);
            if (user == null)
            {
                return NotFound(new { message = "User not found." });
            }

            var post = await _context.Posts.Include(p => p.Likes).FirstOrDefaultAsync(p => p.Id == postId);
            if (post == null)
            {
                return NotFound(new { message = "Post not found." });
            }

            if (post.Likes.Any(l => l.UserEmail == userEmail))
            {
                return BadRequest(new { message = "User already liked this post." });
            }

            var like = new Like
            {
                UserEmail = userEmail,
                PostId = postId,
                CreatedAt = DateTime.UtcNow
            };

            _context.Likes.Add(like);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Post liked successfully." });
        }
    }
}
