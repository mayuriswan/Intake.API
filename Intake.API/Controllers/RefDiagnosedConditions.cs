using Intake.API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Intake.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefDiagnosedConditionsController : ControllerBase
    {
        private readonly IntakeDbContext _context;

        public RefDiagnosedConditionsController(IntakeDbContext context)
        {
            _context = context;
        }

        [HttpGet("active")]
        public async Task<IActionResult> GetActiveDiagnosedConditions()
        {
            var activeConditions = await _context.RefDiagnosedConditions
                .Where(dc => dc.Status)
                .ToListAsync();

            return Ok(activeConditions);
        }
    }
}