using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudyBuddy.DTOs.User;
using StudyBuddy.DTOs.FriendRequest;
using StudyBuddy.Services;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StudyBuddy.Controllers
{
    [ApiController]
    [Route("api/Users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IFriendRequestService _friendService;

        public UserController(IUserService userService, IFriendRequestService friendService)
        {
            _userService = userService;
            _friendService = friendService;
        }

        // GET api/Users/me
        [HttpGet("me")]
        [Authorize]
        public async Task<IActionResult> GetCurrentUser()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userIdClaim)) return Unauthorized();
            if (!Guid.TryParse(userIdClaim, out var id)) return Unauthorized();

            var me = await _userService.GetByIdAsync(id);
            return Ok(me);
        }

        // GET api/Users               (Admin only)
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllUsers()
        {
            var all = await _userService.GetAllUsersAsync();
            return Ok(all);
        }

        // GET api/Users/{id}
        [HttpGet("{id:guid}")]
        [Authorize]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var user = await _userService.GetByIdAsync(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        // POST api/Users
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateUser(UserCreateRequest req)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var created = await _userService.CreateUserAsync(req);
            return CreatedAtAction(nameof(GetUserById), new { id = created.Id }, created);
        }

        // PUT api/Users/{id}
        [HttpPut("{id:guid}")]
        [Authorize]
        public async Task<IActionResult> UpdateUser(Guid id, UpdateUserRequest req)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _userService.UpdateUserAsync(id, req);
            return NoContent();
        }

        // DELETE api/Users/{id}
        [HttpDelete("{id:guid}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var ok = await _userService.DeleteUserAsync(id);
            if (!ok) return NotFound();
            return NoContent();
        }

        // GET api/Users/search?query=&country=&field=
        [HttpGet("search")]
        [Authorize]
        public async Task<IActionResult> SearchUsers(
            [FromQuery] string? query,
            [FromQuery] string? country,
            [FromQuery] string? field)
        {
            var list = await _userService.SearchUsersAsync(query, country, field);
            return Ok(list);
        }

        // POST api/Users/{id}/friend-request
        [HttpPost("{id:guid}/friend-request")]
        [Authorize]
        public async Task<IActionResult> SendFriendRequest(Guid id)
        {
            var fromId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var dto = new FriendRequestCreateDto
            {
                FromUserId = fromId,
                ToUserId = id
            };
            var result = await _friendService.SendRequestAsync(dto);
            return Ok(result);
        }

        // PUT api/Users/friend-request/{requestId}/accept
        [HttpPut("friend-request/{requestId:guid}/accept")]
        [Authorize]
        public async Task<IActionResult> AcceptFriendRequest(Guid requestId)
        {
            var ok = await _friendService.AcceptRequestAsync(requestId);
            if (!ok) return BadRequest();
            return Ok();
        }

        // PUT api/Users/friend-request/{requestId}/reject
        [HttpPut("friend-request/{requestId:guid}/reject")]
        [Authorize]
        public async Task<IActionResult> RejectFriendRequest(Guid requestId)
        {
            var ok = await _friendService.RejectRequestAsync(requestId);
            if (!ok) return BadRequest();
            return Ok();
        }
    }
}
