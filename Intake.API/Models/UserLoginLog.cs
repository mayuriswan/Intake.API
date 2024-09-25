namespace Intake.API.Models
{
    public class UserLoginLog
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string IpAddress { get; set; }
        public DateTime LoginTime { get; set; }
        public string Role { get; set; }
    }
}
