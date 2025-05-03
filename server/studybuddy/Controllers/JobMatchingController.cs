using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StudyBuddy.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class JobMatchingController : ControllerBase
    {
        // Placeholder for future Job Matching Service - returning job recommendations.
    }
}