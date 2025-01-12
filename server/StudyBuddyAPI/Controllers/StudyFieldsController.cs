using StudyBuddyAPI.Models;
using Microsoft.AspNetCore.Mvc;
using StudyBuddyAPI.Data;

namespace StudyBuddyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudyFieldsController : ControllerBase
    {
        private readonly StudyBuddyDbContext _context;

        public StudyFieldsController(StudyBuddyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetStudyFields()
        {
            var studyFields = _context.StudyFields.ToList();

            if (!studyFields.Any())
            {
                return NotFound(new { message = "No study fields found." });
            }

            return Ok(studyFields);
        }

        [HttpPost]
        public IActionResult AddStudyField([FromBody] StudyField newField)
        {
            if (string.IsNullOrWhiteSpace(newField.Name))
            {
                return BadRequest(new { message = "Study field name is required." });
            }

            _context.StudyFields.Add(newField);
            _context.SaveChanges();

            return Ok(new { message = "Study field added successfully.", field = newField });
        }
    }
}
