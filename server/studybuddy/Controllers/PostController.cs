using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using StudyBuddy.DTOs.Comment;
using StudyBuddy.DTOs.Post;
using StudyBuddy.Hubs;
using StudyBuddy.Services;
using System;
using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StudyBuddy.Controllers
{
    [ApiController]
    [Route("api/Posts")]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        private readonly IHubContext<NotificationHub> _hubContext;

        public PostController(IPostService postService, IHubContext<NotificationHub> hubContext)
        {
            _postService = postService;
            _hubContext = hubContext;
        }

        // GET api/Posts
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll()
        {
            Guid? currentUserId = null;
            if (User.Identity?.IsAuthenticated == true)
                currentUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var posts = await _postService.GetAllAsync(currentUserId);
            return Ok(posts);
        }

        // GET api/Posts/{id}
        [HttpGet("{id:guid}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(Guid id)
        {
            Guid? currentUserId = null;
            if (User.Identity?.IsAuthenticated == true)
                currentUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            var dto = await _postService.GetByIdAsync(id, currentUserId);
            return dto is null ? NotFound() : Ok(dto);
        }

        // POST api/Posts
        // Accepts form-data: content, userId, and optional image file
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(
            [FromForm] string content,
            [FromForm] string userId,
            [FromForm] IFormFile? image)
        {
            string? imageUrl = null;

            if (image != null && image.Length > 0)
            {
                // Generate unique filename
                var fileName = Guid.NewGuid() + Path.GetExtension(image.FileName);
                var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");

                // Ensure directory exists
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                // Save file
                var filePath = Path.Combine(folderPath, fileName);
                await using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                }

                // Build accessible URL
                imageUrl = $"{Request.Scheme}://{Request.Host}/uploads/{fileName}";
            }

            // Build DTO
            var dto = new PostCreateDto
            {
                Content = content,
                UserId = Guid.Parse(userId),
                ImageUrl = imageUrl
            };

            // Create post
            var created = await _postService.CreateAsync(dto);

            // Broadcast via SignalR
            await _hubContext.Clients.All.SendAsync("PostCreated", created);

            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        // PUT api/Posts/{id}
        [HttpPut("{id:guid}")]
        [Authorize]
        public async Task<IActionResult> Update(Guid id, [FromBody] PostUpdateDto dto)
        {
            var currentUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var existing = await _postService.GetByIdAsync(id, currentUserId);
            if (existing is null)
                return NotFound();

            if (!User.IsInRole("Admin") && existing.UserId != currentUserId)
                return Forbid();

            var updated = await _postService.UpdateAsync(id, dto);
            return Ok(updated);
        }

        // DELETE api/Posts/{id}
        [HttpDelete("{id:guid}")]
        [Authorize]
        public async Task<IActionResult> Delete(Guid id)
        {
            var currentUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var existing = await _postService.GetByIdAsync(id, currentUserId);
            if (existing is null)
                return NotFound();

            if (!User.IsInRole("Admin") && existing.UserId != currentUserId)
                return Forbid();

            var success = await _postService.DeleteAsync(id);
            return success ? NoContent() : BadRequest();
        }

        // POST api/Posts/{id}/like
        [HttpPost("{id:guid}/like")]
        [Authorize]
        public async Task<IActionResult> Like(Guid id)
        {
            var currentUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var ok = await _postService.AddLikeAsync(currentUserId, id);
            return ok ? Ok() : BadRequest("Already liked");
        }

        // DELETE api/Posts/{id}/like
        [HttpDelete("{id:guid}/like")]
        [Authorize]
        public async Task<IActionResult> Unlike(Guid id)
        {
            var currentUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            await _postService.RemoveLikeAsync(currentUserId, id);
            return Ok();
        }

        // POST api/Posts/{id}/comments
        [HttpPost("{id:guid}/comments")]
        [Authorize]
        public async Task<IActionResult> AddComment(Guid id, [FromBody] CommentCreateDto dto)
        {
            dto.UserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            dto.PostId = id;
            var created = await _postService.AddCommentAsync(dto);
            await _hubContext.Clients.All.SendAsync("CommentAdded", created);
            return CreatedAtAction(nameof(GetById), new { id }, created);
        }

        // GET api/Posts/{id}/comments
        [HttpGet("{id:guid}/comments")]
        [AllowAnonymous]
        public async Task<IActionResult> GetComments(Guid id)
        {
            var comments = await _postService.GetCommentsAsync(id);
            return Ok(comments);
        }
    }
}
