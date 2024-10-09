using Intake.API.Data;
using Intake.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Intake.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntakesController : ControllerBase
    {   
        private readonly IntakeDbContext _context;

        public IntakesController(IntakeDbContext context)
        {
            _context = context;
        }
        [HttpGet("intake/{referenceNumber}")]
        public async Task<IActionResult> GetIntakeByReference(string referenceNumber)
        {
            var intake = await _context.MedicalIntakes
                .Include(i => i.BodyParts) // Include related Body Parts
                .Include(i => i.MedConditions) // Include related MedConditions
                .Include(i => i.SugConditions) // Include related SugConditions
                .FirstOrDefaultAsync(i => i.ReferenceNumber == referenceNumber);

            if (intake == null)
            {
                return NotFound();
            }

            return Ok(intake);
        }

        // GET: api/intakes/search?query={query}
        [HttpGet("search")]
        public async Task<IActionResult> SearchIntakes([FromQuery] string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return BadRequest("Query string cannot be null or empty.");
            }

            // Search for intake forms based on full or partial name or unique intake number
            var searchResults = await _context.MedicalIntakes
                .Where(i => i.FirstName.Contains(query) ||
                            i.LastName.Contains(query) ||
                            i.ReferenceNumber.Contains(query) ||
                            i.MiddleName.Contains(query))
                .Select(i => new
                {
                    i.ReferenceNumber,
                    i.FirstName,
                    i.MiddleName,
                    i.LastName,
                    i.IdNumber,
                    i.DateOfBirth,
                    i.CellNumber,
                    i.HomeNumber,
                    i.WorkNumber,
                    i.Email
                })
                .ToListAsync();

            return Ok(searchResults);
        }

        // Optional: Add an endpoint to search by date range
        // GET: api/intakes/search-by-date?startDate={startDate}&endDate={endDate}
        [HttpGet("search-by-date")]
        public async Task<IActionResult> SearchIntakesByDate([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var searchResults = await _context.MedicalIntakes
                .Select(i => new
                {
                    i.ReferenceNumber,
                    i.FirstName,
                    i.MiddleName,
                    i.LastName,
                    i.IdNumber,
                    i.DateOfBirth,
                    i.CellNumber,
                    i.HomeNumber,
                    i.WorkNumber,
                    i.Email
                })
                .ToListAsync();

            return Ok(searchResults);
        }
    }
}
