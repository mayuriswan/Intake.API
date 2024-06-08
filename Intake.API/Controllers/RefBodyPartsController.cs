using Intake.API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Intake.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefBodyPartsController : ControllerBase
    {
        private readonly IntakeDbContext _context;

        public RefBodyPartsController(IntakeDbContext context)
        {
            _context = context;
        }

        [HttpGet("active")]
        public async Task<IActionResult> GetActiveBodyParts()
        {
            var activeBodyParts = await _context.RefBodyParts
                .Where(bp => bp.Status)
                .ToListAsync();

            return Ok(activeBodyParts);
        }
    }
}
