using Intake.API.Data;
using Intake.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class RefSugConditionsController : ControllerBase
{
    private readonly IntakeDbContext _context;

    public RefSugConditionsController(IntakeDbContext context)
    {
        _context = context;
    }

    [HttpGet("active")]
    public async Task<IActionResult> GetActiveSugConditions()
    {
        var activeSugConditions = await _context.RefSugConditions
            .Where(c => c.Status)
            .ToListAsync();

        return Ok(activeSugConditions);
    }
}
