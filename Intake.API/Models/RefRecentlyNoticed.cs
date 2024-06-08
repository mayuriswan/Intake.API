namespace Intake.API.Models
{
    public class RefRecentlyNoticed
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; } // true for Active, false for Inactive
    }

}
