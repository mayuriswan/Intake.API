namespace Intake.API.Models
{
    public class Config

    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? EmailBody { get; set; } = string.Empty;
    }
}
