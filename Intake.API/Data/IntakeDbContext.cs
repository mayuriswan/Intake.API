using Intake.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Intake.API.Data
{
    public class IntakeDbContext  : DbContext
    {
        public IntakeDbContext(DbContextOptions<IntakeDbContext> options) : base(options)
        {

        }
        public DbSet<MedicalIntake> MedicalIntakes { get; set; }
        public DbSet<RefRecentlyNoticed> RefRecentlyNoticed { get; set; }
        public DbSet<RefBodyParts> RefBodyParts { get; set; }
        public DbSet<MedBodyParts> MedBodyParts { get; set; }
        public DbSet<RefMedCondition> RefMedConditions { get; set; }
        public DbSet<MedCondition> MedConditions { get; set; }
        public DbSet<RefSugCondition> RefSugConditions { get; set; }
        public DbSet<SugCondition> SugConditions { get; set; }
        public DbSet<RefDiagnosedConditions> RefDiagnosedConditions { get; set; }
        public DbSet<RefFamilyDiagnoses> RefFamilyDiagnoses { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MedBodyParts>()
            .HasOne(bp => bp.MedicalIntake)
            .WithMany(mi => mi.BodyParts)
            .HasForeignKey(bp => bp.IntakeReference)
            .HasPrincipalKey(mi => mi.ReferenceNumber);
            modelBuilder.Entity<MedCondition>()
           .HasOne(bp => bp.MedicalIntake)
           .WithMany(mi => mi.MedConditions)
           .HasForeignKey(bp => bp.IntakeReference)
           .HasPrincipalKey(mi => mi.ReferenceNumber);
                    modelBuilder.Entity<SugCondition>()
              .HasOne(bp => bp.MedicalIntake)
              .WithMany(mi => mi.SugConditions)
              .HasForeignKey(bp => bp.IntakeReference)
              .HasPrincipalKey(mi => mi.ReferenceNumber);
                    modelBuilder.Entity<MedicalIntake>()
                               .HasMany(m => m.BodyParts)
                               .WithOne(b => b.MedicalIntake)
                               .HasForeignKey(b => b.IntakeReference);

                                modelBuilder.Entity<MedicalIntake>()
                                    .HasMany(m => m.MedConditions)
                                    .WithOne(c => c.MedicalIntake)
                                    .HasForeignKey(c => c.IntakeReference);

                                modelBuilder.Entity<MedicalIntake>()
                                    .HasMany(m => m.SugConditions)
                                    .WithOne(c => c.MedicalIntake)
                                    .HasForeignKey(c => c.IntakeReference);
            modelBuilder.Entity<RefMedCondition>().HasData(
           new RefMedCondition { Id = 1, Name = "Hypertension", Status = true },
           new RefMedCondition { Id = 2, Name = "Diabetes", Status = true },
           new RefMedCondition { Id = 3, Name = "Asthma", Status = true },
           new RefMedCondition { Id = 4, Name = "Allergies", Status = true },
           new RefMedCondition { Id = 5, Name = "Arthritis", Status = true }
       );

            modelBuilder.Entity<RefSugCondition>().HasData(
                new RefSugCondition { Id = 1, Name = "Appendectomy", Status = true },
                new RefSugCondition { Id = 2, Name = "Gallbladder Removal", Status = true },
                new RefSugCondition { Id = 3, Name = "Hernia Repair", Status = true },
                new RefSugCondition { Id = 4, Name = "Cataract Surgery", Status = true },
                new RefSugCondition { Id = 5, Name = "Joint Replacement", Status = true }
            );

            modelBuilder.Entity<RefRecentlyNoticed>().HasData(
                new RefRecentlyNoticed { Id = 1, Name = "Cough", Status = true },
                new RefRecentlyNoticed { Id = 2, Name = "Difficulty Swallowing", Status = true },
                new RefRecentlyNoticed { Id = 3, Name = "Falls", Status = true },
                new RefRecentlyNoticed { Id = 4, Name = "Headaches", Status = true },
                new RefRecentlyNoticed { Id = 5, Name = "Nausea/Vomiting", Status = true },
                new RefRecentlyNoticed { Id = 6, Name = "Skin Changes", Status = true },
                new RefRecentlyNoticed { Id = 7, Name = "Weight Loss/Gain", Status = true },
                new RefRecentlyNoticed { Id = 8, Name = "Changed in bowel or bladder function", Status = true },
                new RefRecentlyNoticed { Id = 9, Name = "Constipation", Status = true },
                new RefRecentlyNoticed { Id = 10, Name = "Diarrhea", Status = true },
                new RefRecentlyNoticed { Id = 11, Name = "Dizziness/lightheadedness", Status = true },
                new RefRecentlyNoticed { Id = 12, Name = "Fatigue", Status = true },
                new RefRecentlyNoticed { Id = 13, Name = "Heartburn/Indigestion", Status = true },
                new RefRecentlyNoticed { Id = 14, Name = "Muscle Weakness", Status = true },
                new RefRecentlyNoticed { Id = 15, Name = "Numbness or Tingling", Status = true },
                new RefRecentlyNoticed { Id = 16, Name = "Shortness of breath", Status = true },
                new RefRecentlyNoticed { Id = 17, Name = "Weight Gain", Status = true },
                new RefRecentlyNoticed { Id = 18, Name = "Weight Loss", Status = true },
                new RefRecentlyNoticed { Id = 19, Name = "Fainting", Status = true },
                new RefRecentlyNoticed { Id = 20, Name = "Fever/Chills/Sweats", Status = true },
                new RefRecentlyNoticed { Id = 21, Name = "Difficulty maintaining balance while walking", Status = true }
            );
            modelBuilder.Entity<RefBodyParts>().HasData(
              new RefBodyParts { Id = 1, Name = "Right Arm", Status = true },
              new RefBodyParts { Id = 2, Name = "Left Arm", Status = true },
              new RefBodyParts { Id = 3, Name = "Right Knee", Status = true },
              new RefBodyParts { Id = 4, Name = "Left Knee", Status = true },
              new RefBodyParts { Id = 5, Name = "Head", Status = true },
              new RefBodyParts { Id = 6, Name = "Neck", Status = true },
              new RefBodyParts { Id = 7, Name = "Right Foot", Status = true },
              new RefBodyParts { Id = 8, Name = "Left Foot", Status = true }
          );
            modelBuilder.Entity<RefDiagnosedConditions>().HasData(
    new RefDiagnosedConditions { Id = 1, Name = "Bladder/Urinary Tract Infection", Status = true },
    new RefDiagnosedConditions { Id = 2, Name = "Cancer", Status = true },
    new RefDiagnosedConditions { Id = 3, Name = "Circulation Problems", Status = true },
    new RefDiagnosedConditions { Id = 4, Name = "Depression", Status = true },
    new RefDiagnosedConditions { Id = 5, Name = "Eye Problem/infection", Status = true },
    new RefDiagnosedConditions { Id = 6, Name = "Hepatitis", Status = true },
    new RefDiagnosedConditions { Id = 7, Name = "Liver Problems", Status = true },
    new RefDiagnosedConditions { Id = 8, Name = "No Prone Lying", Status = true },
    new RefDiagnosedConditions { Id = 9, Name = "Other Arthritic Conditions", Status = true },
    new RefDiagnosedConditions { Id = 10, Name = "Psoriasis", Status = true },
    new RefDiagnosedConditions { Id = 11, Name = "Spina Bifida", Status = true },
    new RefDiagnosedConditions { Id = 12, Name = "Tuberculosis", Status = true },
    new RefDiagnosedConditions { Id = 13, Name = "Anemia", Status = true },
    new RefDiagnosedConditions { Id = 14, Name = "Asthma", Status = true },
    new RefDiagnosedConditions { Id = 15, Name = "Blood Clots", Status = true },
    new RefDiagnosedConditions { Id = 16, Name = "Bone or Joint Infection", Status = true },
    new RefDiagnosedConditions { Id = 17, Name = "Chemical Dependency (i.e., alcoholism)", Status = true },
    new RefDiagnosedConditions { Id = 18, Name = "Chest Pain/Angina", Status = true },
    new RefDiagnosedConditions { Id = 19, Name = "Costochondritis", Status = true },
    new RefDiagnosedConditions { Id = 20, Name = "CostoChronditis", Status = true },
    new RefDiagnosedConditions { Id = 21, Name = "Diabetes", Status = true },
    new RefDiagnosedConditions { Id = 22, Name = "Epilepsy", Status = true },
    new RefDiagnosedConditions { Id = 23, Name = "Fibromyalgia", Status = true },
    new RefDiagnosedConditions { Id = 24, Name = "Heart Problems", Status = true },
    new RefDiagnosedConditions { Id = 25, Name = "High Blood Pressure", Status = true },
    new RefDiagnosedConditions { Id = 26, Name = "Kidney Problem/Infection", Status = true },
    new RefDiagnosedConditions { Id = 27, Name = "Lung Problems", Status = true },
    new RefDiagnosedConditions { Id = 28, Name = "Multiple Sclerosis", Status = true },
    new RefDiagnosedConditions { Id = 29, Name = "No Supine Lying", Status = true },
    new RefDiagnosedConditions { Id = 30, Name = "Osteoporosis", Status = true },
    new RefDiagnosedConditions { Id = 31, Name = "Pelvic Inflammatory Disease", Status = true },
    new RefDiagnosedConditions { Id = 32, Name = "Pneumonia", Status = true },
    new RefDiagnosedConditions { Id = 33, Name = "Rheumatoid Arthritis", Status = true },
    new RefDiagnosedConditions { Id = 34, Name = "Sexually Transmitted Disease/HIV", Status = true },
    new RefDiagnosedConditions { Id = 35, Name = "Stroke", Status = true },
    new RefDiagnosedConditions { Id = 36, Name = "Thyroid Problems", Status = true },
    new RefDiagnosedConditions { Id = 37, Name = "Ulcers", Status = true }
);
            modelBuilder.Entity<RefFamilyDiagnoses>().HasData(
        new RefFamilyDiagnoses { Id = 1, Name = "Blood Clots", Status = "Active" },
        new RefFamilyDiagnoses { Id = 2, Name = "Heart Problems", Status = "Active" },
        new RefFamilyDiagnoses { Id = 3, Name = "Stroke", Status = "Active" },
        new RefFamilyDiagnoses { Id = 4, Name = "Cancer", Status = "Active" },
        new RefFamilyDiagnoses { Id = 5, Name = "Diabetes", Status = "Active" },
        new RefFamilyDiagnoses { Id = 6, Name = "High Blood Pressure", Status = "Active" },
        new RefFamilyDiagnoses { Id = 7, Name = "Thyroid Problems", Status = "Active" },
        new RefFamilyDiagnoses { Id = 8, Name = "Depression", Status = "Active" },
        new RefFamilyDiagnoses { Id = 9, Name = "Tuberculosis", Status = "Active" }
    );

        }
    }
}
