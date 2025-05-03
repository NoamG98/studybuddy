using Microsoft.AspNetCore.Mvc;
using StudyBuddy.Services;
using StudyBuddy.DTOs.Mentorship;


namespace StudyBuddy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MentorshipController : ControllerBase
    {
        private readonly IMentorshipService _mentorshipService;

        public MentorshipController(IMentorshipService mentorshipService)
        {
            _mentorshipService = mentorshipService;
        }

        [HttpPost("request")]
        public async Task<IActionResult> RequestMentorship([FromBody] RequestMentorshipDto request)
        {
            var mentorship = await _mentorshipService.RequestMentorshipAsync(request);
            return Ok(mentorship);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMentorships()
        {
            var mentorships = await _mentorshipService.GetAllMentorshipsAsync();
            return Ok(mentorships);
        }
    }
}