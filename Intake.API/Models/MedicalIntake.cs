namespace Intake.API.Models
{
    public class MedicalIntake
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? ReferenceNumber { get; set; }

        // Additional fields from the form
        public string? MiddleName { get; set; }
        public string? MaritalStatus { get; set; }
        public string? IdType { get; set; }
        public string? IdNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Country { get; set; }
        public string? CellNumber { get; set; }
        public string? HomeNumber { get; set; }
        public string? WorkNumber { get; set; }

        // Fields for step 2
        public string? WorkRestriction { get; set; }
        public string? MedicalLegalCase { get; set; }
        public string? LatexSensitive { get; set; }
        public string? Smoke { get; set; }
        public string? ImplantedDevice { get; set; }
        public string? ImplantedDeviceDetails { get; set; }
        public string? Pregnant { get; set; }
        public string? Allergies { get; set; }

        // Fields for step 3
        public string? RecentlyNoted { get; set; }

        // Fields for step 5
        public DateTime? SymptomStartDate { get; set; }
        public string? SymptomStartEst { get; set; } = string.Empty;

        public string? SymptomCause { get; set; }= string.Empty;
        public string? SymptomStatus { get; set; } = string.Empty;
        public string? PhysicalActivity { get; set; }=string.Empty;
        public string? TreatmentReceived { get; set; } = string.Empty;
        public string? SpecialTests { get; set; } = string.Empty;
        public bool? HadProblemBefore { get; set; } = false;
        public string? ProblemBeforeWhen { get; set; }=string.Empty ;
        public string? TreatmentBefore { get; set; } = string.Empty;
        // Fields for step 6
        public string? AggravatingFactors { get; set; }
        public string? EasingFactors { get; set; }
        public string? SleepIssues { get; set; }
        public string? WorstSymptoms { get; set; }
        public string? BestSymptoms { get; set; }
        public int? CurrentPainLevel { get; set; }
        public int? BestPainLevel { get; set; }
        public int? WorstPainLevel { get; set; }

        // Navigation property for related body parts
        public ICollection<MedBodyParts>? BodyParts { get; set; }
        // Step 7
        public bool? SteroidMedications { get; set; }
        public bool? BloodThinningMedications { get; set; }
      
        public ICollection<MedCondition>? MedConditions { get; set; }
        public ICollection<SugCondition>? SugConditions { get; set; }

        // New property for step 8
        public string? DiagnosedConditions { get; set; }

        // new property for step 9
        public bool IsSubmitted { get; set; }
        public bool? FeelingDown { get; set; }
        public bool? LittleInterest { get; set; }
        public bool? WantHelp { get; set; }
        public bool? UnsafeAtHome { get; set; }
        public string? TherapyGoals { get; set; }
        public string? OtherProblems { get; set; }
    }
}
