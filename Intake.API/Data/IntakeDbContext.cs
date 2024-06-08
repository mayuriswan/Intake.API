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
        }
    }
}
