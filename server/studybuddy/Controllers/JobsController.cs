using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StudyBuddy.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class JobsController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAll() => Ok(Array.Empty<object>());
    }
}
