using Intake.API.Data;
using Intake.API.Models;
using Microsoft.AspNetCore.Authorization;
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
        public async Task<IActionResult> AddUser([FromBody] User newUser)
        {
            if (newUser == null || string.IsNullOrWhiteSpace(newUser.Username) || string.IsNullOrWhiteSpace(newUser.PasswordHash))
            {
                return BadRequest("Invalid user data.");
            }

            if (await _context.Users.AnyAsync(u => u.Username == newUser.Username))
            {
                return BadRequest("Username already exists.");
            }

            // Hash the password using a custom SHA256 hash function
            newUser.PasswordHash = HashPassword(newUser.PasswordHash);

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return Ok(new { message = "User created successfully!" });
        }

        // Custom password hashing function using SHA256
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                // Compute the hash as a byte array
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                // Convert the byte array to a Base64 string to store in the database
                return Convert.ToBase64String(hashedBytes);
            }

        }

        // Admin only - Get all users
        [HttpGet("all-users")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _context.Users.Select(u => new
            {
                u.Id,
                u.Username,
                u.Role,
                u.Name          }).ToListAsync();

            return Ok(users);
        }

        // Admin only - Remove User
        [HttpDelete("remove-user/{id}")]
        public async Task<IActionResult> RemoveUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return Ok(new { message = "User removed successfully!" });
        }
    }
}
