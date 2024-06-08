namespace Intake.API.Models
{
    public class MedBodyParts
    {
        public int Id { get; set; }
        public string IntakeReference { get; set; }
        public string BodyPart { get; set; }
        public string Issue { get; set; }
        public MedicalIntake? MedicalIntake { get; set; }
    }
}
