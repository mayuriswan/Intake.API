using System.ComponentModel.DataAnnotations.Schema;

namespace Intake.API.Models
{
    public class MedCondition
    {
        public int Id { get; set; }
        public string IntakeReference { get; set; }
        public string Name { get; set; }

        public MedicalIntake? MedicalIntake { get; set; }
    }
}
