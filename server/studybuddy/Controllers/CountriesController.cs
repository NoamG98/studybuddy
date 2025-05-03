using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace StudyBuddy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<string>> GetAll()
        {
            var cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            var countries = cultures
                .Select(c =>
                {
                    try
                    {
                        return new RegionInfo(c.LCID).EnglishName;
                    }
                    catch
                    {
                        return null;
                    }
                })
                .Where(name => !string.IsNullOrEmpty(name))
                .Distinct()
                .OrderBy(name => name)
                .ToList();

            return Ok(countries);
        }
    }
}