using Intake.API.Data;
using Intake.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace Intake.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IntakeDbContext _context;

        public LoginController(IntakeDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == loginRequest.Username);
            if (user == null || !VerifyPasswordHash(loginRequest.Password, user.PasswordHash))
            {
                return Unauthorized("Invalid credentials.");
            }

            // Log login details
            var loginLog = new UserLoginLog
            {
                Username = user.Username,
                IpAddress = HttpContext.Connection.RemoteIpAddress.ToString(),
                LoginTime = DateTime.Now,
                Role = user.Role
            };
            await _context.UserLoginLogs.AddAsync(loginLog);
            await _context.SaveChangesAsync();

            return Ok(new { role = user.Role, username = user.Username });
        }

        private bool VerifyPasswordHash(string password, string storedHash)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                var passwordHash = Convert.ToBase64String(hashedBytes);
                return passwordHash == storedHash;
            }
        }
    }
    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
