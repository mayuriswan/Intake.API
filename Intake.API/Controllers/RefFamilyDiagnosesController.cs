using Intake.API.Data;
using Intake.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Intake.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefFamilyDiagnosesController : ControllerBase
    {
        private readonly IntakeDbContext _context;

        public RefFamilyDiagnosesController(IntakeDbContext context)
        {
            _context = context;
        }

        [HttpGet("active")]
        public async Task<ActionResult<IEnumerable<RefFamilyDiagnoses>>> GetActiveFamilyDiagnoses()
        {
            return await _context.RefFamilyDiagnoses
                .Where(d => d.Status == "Active")
                .ToListAsync();
        }
    }

}
