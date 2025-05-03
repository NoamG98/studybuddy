using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudyBuddy.Services;

namespace StudyBuddy.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class LeaderboardController : ControllerBase
    {
        private readonly ILeaderboardService _leaderboardService;

        public LeaderboardController(ILeaderboardService leaderboardService)
        {
            _leaderboardService = leaderboardService;
        }

        [HttpGet("top")]
        public async Task<IActionResult> GetLeaderboard()
        {
            var response = await _leaderboardService.GetLeaderboardAsync();
            return Ok(response);
        }
    }
}
