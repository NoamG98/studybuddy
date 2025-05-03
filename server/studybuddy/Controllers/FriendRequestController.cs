using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudyBuddy.DTOs.FriendRequest;
using StudyBuddy.Services;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StudyBuddy.Controllers
{
    [ApiController]
    [Route("api/FriendRequests")]
    public class FriendRequestController : ControllerBase
    {
        private readonly IFriendRequestService _service;

        public FriendRequestController(IFriendRequestService service)
            => _service = service;

        // POST api/FriendRequests
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Send([FromBody] FriendRequestCreateDto dto)
        {
            dto.FromUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var result = await _service.SendRequestAsync(dto);
            return CreatedAtAction(nameof(Send), new { id = result.Id }, result);
        }

        // PUT api/FriendRequests/{id}/accept
        [HttpPut("{id:guid}/accept")]
        [Authorize]
        public async Task<IActionResult> Accept(Guid id)
            => Ok(await _service.AcceptRequestAsync(id));

        // PUT api/FriendRequests/{id}/reject
        [HttpPut("{id:guid}/reject")]
        [Authorize]
        public async Task<IActionResult> Reject(Guid id)
            => Ok(await _service.RejectRequestAsync(id));

        // GET api/FriendRequests/sent
        [HttpGet("sent")]
        [Authorize]
        public async Task<IActionResult> Sent()
        {
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var list = await _service.GetSentRequestsAsync(userId);
            return Ok(list);
        }

        // GET api/FriendRequests/received
        [HttpGet("received")]
        [Authorize]
        public async Task<IActionResult> Received()
        {
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var list = await _service.GetReceivedRequestsAsync(userId);
            return Ok(list);
        }

        // GET api/FriendRequests/friends
        [HttpGet("friends")]
        [Authorize]
        public async Task<IActionResult> Friends()
        {
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var friends = await _service.GetFriendsAsync(userId);
            return Ok(friends);
        }
    }
}