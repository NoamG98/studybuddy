using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudyBuddy.Models;
using StudyBuddy.Services;
using StudyBuddy.DTOs.Activity;

namespace StudyBuddy.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityService _activityService;

        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ActivityResponse>>> GetAll()
        {
            var activities = await _activityService.GetAllActivitiesAsync();
            return Ok(activities.Select(a => new ActivityResponse
            {
                Id = a.Id,
                ActionType = a.ActionType,
                Timestamp = a.Timestamp,
                Description = a.Description ?? string.Empty 
            }).ToList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ActivityResponse>> GetById(Guid id)
        {
            var activity = await _activityService.GetActivityByIdAsync(id);
            if (activity == null) return NotFound();
            return Ok(new ActivityResponse
            {
                Id = activity.Id,
                ActionType = activity.ActionType,
                Timestamp = activity.Timestamp,
                Description = activity.Description ?? string.Empty 
            });
        }

        [HttpPost]
        public async Task<ActionResult<ActivityResponse>> Create(ActivityCreateRequest request)
        {
            var activity = new Activity
            {
                UserId = request.UserId,
                User = new User
                {
                    Id = request.UserId,
                    FirstName = "Default FirstName",
                    LastName = "Default LastName",
                    Email = "default@example.com",
                    PasswordHash = "defaultHash",
                    Role = "DefaultRole",
                    City = "DefaultCity",
                    Country = "DefaultCountry"
                },
                ActionType = request.ActionType,
                Description = request.Description ?? string.Empty, // Fix for CS8601
                Timestamp = DateTime.UtcNow
            };

            var created = await _activityService.CreateActivityAsync(activity);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, new ActivityResponse
            {
                Id = created.Id,
                ActionType = created.ActionType,
                Timestamp = created.Timestamp,
                Description = created.Description ?? string.Empty // Fix for CS8601
            });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var success = await _activityService.DeleteActivityAsync(id);
            if (!success) return NotFound();
            return NoContent();
        }
    }
}
