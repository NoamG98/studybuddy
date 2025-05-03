using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudyBuddy.Models;
using StudyBuddy.Services;
using System;
using System.Threading.Tasks;

namespace StudyBuddy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LikeController : ControllerBase
    {
        private readonly ILikeService _likeService;

        public LikeController(ILikeService likeService)
        {
            _likeService = likeService;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddLike([FromBody] Guid postId)
        {
            var userId = User.Identity?.Name;
            if (string.IsNullOrEmpty(userId)) return Unauthorized();

            var result = await _likeService.AddLikeAsync(Guid.Parse(userId), postId);
            return result ? Ok() : BadRequest("Like already exists.");
        }

        [HttpDelete("{postId}")]
        [Authorize]
        public async Task<IActionResult> RemoveLike(Guid postId)
        {
            var userId = User.Identity?.Name;
            if (string.IsNullOrEmpty(userId)) return Unauthorized();

            await _likeService.RemoveLikeAsync(Guid.Parse(userId), postId);
            return Ok();
        }

        [HttpGet("count/{postId}")]
        public async Task<IActionResult> GetLikeCount(Guid postId)
        {
            var count = await _likeService.GetLikeCountAsync(postId);
            return Ok(count);
        }
    }
}