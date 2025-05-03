using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudyBuddy.DTOs.Chat;
using StudyBuddy.Services;

namespace StudyBuddy.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendMessage([FromBody] SendMessageRequest request)
        {
            var senderClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (senderClaim is null) return Unauthorized();

            var senderId = Guid.Parse(senderClaim);
            var response = await _chatService.SendMessageAsync(request, senderId);
            return Ok(response);
        }

        [HttpGet("history/{otherUserId}")]
        public async Task<IActionResult> GetHistory(string otherUserId)
        {
            var senderClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (senderClaim is null) return Unauthorized();

            var meId = Guid.Parse(senderClaim);
            var otherId = Guid.Parse(otherUserId); 
            var convo = await _chatService.GetConversationAsync(meId, otherId);
            return Ok(convo);
        }
    }
}
