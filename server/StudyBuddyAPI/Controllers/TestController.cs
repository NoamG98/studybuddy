using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StudyBuddyAPI.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class TestController : ControllerBase
    {

        [HttpGet("public")]
        public IActionResult PublicEndpoint()
        {
            Console.WriteLine("Accessed public endpoint.");
            return Ok(new { message = "This is a public endpoint!" });
        }


        [Authorize]
        [HttpGet("secure")]
        public IActionResult SecureEndpoint()
        {
            var userEmail = User.Identity?.Name;
            Console.WriteLine($"Accessed secure endpoint by user: {userEmail}");

            return Ok(new { message = "This is a secure endpoint!", userEmail });
        }
    }
}
