using Intake.API.Data;
using Intake.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class RefMedConditionsController : ControllerBase
{
    private readonly IntakeDbContext _context;

    public RefMedConditionsController(IntakeDbContext context)
    {
        _context = context;
    }

    [HttpGet("active")]
    public async Task<IActionResult> GetActiveMedConditions()
    {
        var activeMedConditions = await _context.RefMedConditions
            .Where(c => c.Status)
            .ToListAsync();

        return Ok(activeMedConditions);
    }
}
