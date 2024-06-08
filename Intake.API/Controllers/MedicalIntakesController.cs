using Intake.API.Data;
using Intake.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;
using Intake.API.Data;
using Microsoft.EntityFrameworkCore;

namespace Intake.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalIntakesController : ControllerBase
    {
        private readonly API.Data.IntakeDbContext _context;

        public MedicalIntakesController(API.Data.IntakeDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMedicalIntake([FromBody] MedicalIntake intake)
        {
            if (ModelState.IsValid)
            {
                intake.ReferenceNumber = GenerateReferenceNumber();
                _context.MedicalIntakes.Add(intake);
                await _context.SaveChangesAsync();

                return Ok(new { referenceNumber = intake.ReferenceNumber });
            }

            return BadRequest(ModelState);
        }

        [HttpGet("{referenceNumber}")]
        public async Task<IActionResult> GetIntakeByReference(string referenceNumber)
                {
            var intake = await _context.MedicalIntakes
                .FirstOrDefaultAsync(i => i.ReferenceNumber == referenceNumber);

            if (intake == null)
            {
                return NotFound();
            }

            return Ok(intake);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMedicalIntake(int id, [FromBody] MedicalIntake intake)
        {
            if (id != intake.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Detach the existing intake body parts, medical conditions, and surgery conditions to avoid conflicts
            var existingBodyParts = await _context.MedBodyParts.Where(bp => bp.IntakeReference == intake.ReferenceNumber).ToListAsync();
            var existingMedConditions = await _context.MedConditions.Where(mc => mc.IntakeReference == intake.ReferenceNumber).ToListAsync();
            var existingSugConditions = await _context.SugConditions.Where(sc => sc.IntakeReference == intake.ReferenceNumber).ToListAsync();

            _context.MedBodyParts.RemoveRange(existingBodyParts);
            _context.MedConditions.RemoveRange(existingMedConditions);
            _context.SugConditions.RemoveRange(existingSugConditions);

            _context.Entry(intake).State = EntityState.Modified;

            // Save the intake first
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicalIntakeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            // Add the updated body parts
            if (intake.BodyParts != null && intake.BodyParts.Any())
            {
                foreach (var bodyPart in intake.BodyParts)
                {
                    bodyPart.IntakeReference = intake.ReferenceNumber; // Ensure the reference is set
                    _context.MedBodyParts.Add(bodyPart);
                }
            }

            // Add the updated medical conditions
            if (intake.MedConditions != null && intake.MedConditions.Any())
            {
                foreach (var medCondition in intake.MedConditions)
                {
                    medCondition.IntakeReference = intake.ReferenceNumber; // Ensure the reference is set
                    _context.MedConditions.Add(medCondition);
                }
            }

            // Add the updated surgery conditions
            if (intake.SugConditions != null && intake.SugConditions.Any())
            {
                foreach (var sugCondition in intake.SugConditions)
                {
                    sugCondition.IntakeReference = intake.ReferenceNumber; // Ensure the reference is set
                    _context.SugConditions.Add(sugCondition);
                }
            }

            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MedicalIntakeExists(int id)
        {
            return _context.MedicalIntakes.Any(e => e.Id == id);
        }
        private string GenerateReferenceNumber()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            using (var crypto = new RNGCryptoServiceProvider())
            {
                var data = new byte[7];
                crypto.GetBytes(data);
                var result = new StringBuilder(7);
                foreach (var b in data)
                {
                    result.Append(chars[b % chars.Length]);
                }
                return result.ToString();
            }
        }
    }
}
