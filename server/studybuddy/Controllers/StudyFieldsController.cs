using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudyBuddy.Data;
using StudyBuddy.Models;

namespace StudyBuddy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudyFieldsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public StudyFieldsController(ApplicationDbContext db) => _db = db;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudyField>>> GetAll()
        {
            var list = await _db.StudyFields
                                .OrderBy(sf => sf.Name)
                                .ToListAsync();
            return Ok(list);
        }
    }
}
