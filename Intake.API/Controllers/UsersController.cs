using Intake.API.Data;
using Intake.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace Intake.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IntakeDbContext _context;

        public UsersController(IntakeDbContext context)
        {
            _context = context;
        }

        // Admin only - Add User
        [HttpPost("add-user")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddUser([FromBody] User newUser)
        {
            if (await _context.Users.AnyAsync(u => u.Username == newUser.Username))
            {
                return BadRequest("Username already exists.");
            }

            newUser.PasswordHash = HashPassword(newUser.PasswordHash); // Hash the password
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();
            return Ok();
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }
    }
}
