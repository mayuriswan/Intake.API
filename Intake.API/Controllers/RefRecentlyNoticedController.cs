using Intake.API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Intake.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefRecentlyNoticedController : ControllerBase
    {
        private readonly IntakeDbContext _context;

        public RefRecentlyNoticedController(IntakeDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetActiveFields()
        {
            var fields = await _context.RefRecentlyNoticed
                .Where(r => r.Status == true)
                .Select(r => new { r.Id, r.Name })
                .ToListAsync();

            return Ok(fields);
        }
    }
}
