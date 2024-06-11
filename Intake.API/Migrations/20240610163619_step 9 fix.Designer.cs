﻿// <auto-generated />
using System;
using Intake.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Intake.API.Migrations
{
    [DbContext(typeof(IntakeDbContext))]
    [Migration("20240610163619_step 9 fix")]
    partial class step9fix
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.4.24267.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Intake.API.Models.MedBodyParts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BodyPart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntakeReference")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Issue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IntakeReference");

                    b.ToTable("MedBodyParts");
                });

            modelBuilder.Entity("Intake.API.Models.MedCondition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("IntakeReference")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IntakeReference");

                    b.ToTable("MedConditions");
                });

            modelBuilder.Entity("Intake.API.Models.MedicalIntake", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AggravatingFactors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Allergies")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BestPainLevel")
                        .HasColumnType("int");

                    b.Property<string>("BestSymptoms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("BloodThinningMedications")
                        .HasColumnType("bit");

                    b.Property<string>("CellNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CurrentPainLevel")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("DiagnosedConditions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EasingFactors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("FeelingDown")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("HadProblemBefore")
                        .HasColumnType("bit");

                    b.Property<string>("HomeNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImplantedDevice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImplantedDeviceDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSubmitted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LatexSensitive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("LittleInterest")
                        .HasColumnType("bit");

                    b.Property<string>("MaritalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalLegalCase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherProblems")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhysicalActivity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pregnant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProblemBeforeWhen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecentlyNoted")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SleepIssues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Smoke")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecialTests")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("SteroidMedications")
                        .HasColumnType("bit");

                    b.Property<string>("SymptomCause")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("SymptomStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SymptomStartEst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SymptomStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TherapyGoals")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TreatmentBefore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TreatmentReceived")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("UnsafeAtHome")
                        .HasColumnType("bit");

                    b.Property<bool?>("WantHelp")
                        .HasColumnType("bit");

                    b.Property<string>("WorkNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkRestriction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorstPainLevel")
                        .HasColumnType("int");

                    b.Property<string>("WorstSymptoms")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MedicalIntakes");
                });

            modelBuilder.Entity("Intake.API.Models.RefBodyParts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("RefBodyParts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Right Arm",
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            Name = "Left Arm",
                            Status = true
                        },
                        new
                        {
                            Id = 3,
                            Name = "Right Knee",
                            Status = true
                        },
                        new
                        {
                            Id = 4,
                            Name = "Left Knee",
                            Status = true
                        },
                        new
                        {
                            Id = 5,
                            Name = "Head",
                            Status = true
                        },
                        new
                        {
                            Id = 6,
                            Name = "Neck",
                            Status = true
                        },
                        new
                        {
                            Id = 7,
                            Name = "Right Foot",
                            Status = true
                        },
                        new
                        {
                            Id = 8,
                            Name = "Left Foot",
                            Status = true
                        });
                });

            modelBuilder.Entity("Intake.API.Models.RefDiagnosedConditions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("RefDiagnosedConditions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bladder/Urinary Tract Infection",
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cancer",
                            Status = true
                        },
                        new
                        {
                            Id = 3,
                            Name = "Circulation Problems",
                            Status = true
                        },
                        new
                        {
                            Id = 4,
                            Name = "Depression",
                            Status = true
                        },
                        new
                        {
                            Id = 5,
                            Name = "Eye Problem/infection",
                            Status = true
                        },
                        new
                        {
                            Id = 6,
                            Name = "Hepatitis",
                            Status = true
                        },
                        new
                        {
                            Id = 7,
                            Name = "Liver Problems",
                            Status = true
                        },
                        new
                        {
                            Id = 8,
                            Name = "No Prone Lying",
                            Status = true
                        },
                        new
                        {
                            Id = 9,
                            Name = "Other Arthritic Conditions",
                            Status = true
                        },
                        new
                        {
                            Id = 10,
                            Name = "Psoriasis",
                            Status = true
                        },
                        new
                        {
                            Id = 11,
                            Name = "Spina Bifida",
                            Status = true
                        },
                        new
                        {
                            Id = 12,
                            Name = "Tuberculosis",
                            Status = true
                        },
                        new
                        {
                            Id = 13,
                            Name = "Anemia",
                            Status = true
                        },
                        new
                        {
                            Id = 14,
                            Name = "Asthma",
                            Status = true
                        },
                        new
                        {
                            Id = 15,
                            Name = "Blood Clots",
                            Status = true
                        },
                        new
                        {
                            Id = 16,
                            Name = "Bone or Joint Infection",
                            Status = true
                        },
                        new
                        {
                            Id = 17,
                            Name = "Chemical Dependency (i.e., alcoholism)",
                            Status = true
                        },
                        new
                        {
                            Id = 18,
                            Name = "Chest Pain/Angina",
                            Status = true
                        },
                        new
                        {
                            Id = 19,
                            Name = "Costochondritis",
                            Status = true
                        },
                        new
                        {
                            Id = 20,
                            Name = "CostoChronditis",
                            Status = true
                        },
                        new
                        {
                            Id = 21,
                            Name = "Diabetes",
                            Status = true
                        },
                        new
                        {
                            Id = 22,
                            Name = "Epilepsy",
                            Status = true
                        },
                        new
                        {
                            Id = 23,
                            Name = "Fibromyalgia",
                            Status = true
                        },
                        new
                        {
                            Id = 24,
                            Name = "Heart Problems",
                            Status = true
                        },
                        new
                        {
                            Id = 25,
                            Name = "High Blood Pressure",
                            Status = true
                        },
                        new
                        {
                            Id = 26,
                            Name = "Kidney Problem/Infection",
                            Status = true
                        },
                        new
                        {
                            Id = 27,
                            Name = "Lung Problems",
                            Status = true
                        },
                        new
                        {
                            Id = 28,
                            Name = "Multiple Sclerosis",
                            Status = true
                        },
                        new
                        {
                            Id = 29,
                            Name = "No Supine Lying",
                            Status = true
                        },
                        new
                        {
                            Id = 30,
                            Name = "Osteoporosis",
                            Status = true
                        },
                        new
                        {
                            Id = 31,
                            Name = "Pelvic Inflammatory Disease",
                            Status = true
                        },
                        new
                        {
                            Id = 32,
                            Name = "Pneumonia",
                            Status = true
                        },
                        new
                        {
                            Id = 33,
                            Name = "Rheumatoid Arthritis",
                            Status = true
                        },
                        new
                        {
                            Id = 34,
                            Name = "Sexually Transmitted Disease/HIV",
                            Status = true
                        },
                        new
                        {
                            Id = 35,
                            Name = "Stroke",
                            Status = true
                        },
                        new
                        {
                            Id = 36,
                            Name = "Thyroid Problems",
                            Status = true
                        },
                        new
                        {
                            Id = 37,
                            Name = "Ulcers",
                            Status = true
                        });
                });

            modelBuilder.Entity("Intake.API.Models.RefFamilyDiagnoses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RefFamilyDiagnoses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Blood Clots",
                            Status = "Active"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Heart Problems",
                            Status = "Active"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Stroke",
                            Status = "Active"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Cancer",
                            Status = "Active"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Diabetes",
                            Status = "Active"
                        },
                        new
                        {
                            Id = 6,
                            Name = "High Blood Pressure",
                            Status = "Active"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Thyroid Problems",
                            Status = "Active"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Depression",
                            Status = "Active"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Tuberculosis",
                            Status = "Active"
                        });
                });

            modelBuilder.Entity("Intake.API.Models.RefMedCondition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("RefMedConditions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hypertension",
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            Name = "Diabetes",
                            Status = true
                        },
                        new
                        {
                            Id = 3,
                            Name = "Asthma",
                            Status = true
                        },
                        new
                        {
                            Id = 4,
                            Name = "Allergies",
                            Status = true
                        },
                        new
                        {
                            Id = 5,
                            Name = "Arthritis",
                            Status = true
                        });
                });

            modelBuilder.Entity("Intake.API.Models.RefRecentlyNoticed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("RefRecentlyNoticed");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cough",
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            Name = "Difficulty Swallowing",
                            Status = true
                        },
                        new
                        {
                            Id = 3,
                            Name = "Falls",
                            Status = true
                        },
                        new
                        {
                            Id = 4,
                            Name = "Headaches",
                            Status = true
                        },
                        new
                        {
                            Id = 5,
                            Name = "Nausea/Vomiting",
                            Status = true
                        },
                        new
                        {
                            Id = 6,
                            Name = "Skin Changes",
                            Status = true
                        },
                        new
                        {
                            Id = 7,
                            Name = "Weight Loss/Gain",
                            Status = true
                        },
                        new
                        {
                            Id = 8,
                            Name = "Changed in bowel or bladder function",
                            Status = true
                        },
                        new
                        {
                            Id = 9,
                            Name = "Constipation",
                            Status = true
                        },
                        new
                        {
                            Id = 10,
                            Name = "Diarrhea",
                            Status = true
                        },
                        new
                        {
                            Id = 11,
                            Name = "Dizziness/lightheadedness",
                            Status = true
                        },
                        new
                        {
                            Id = 12,
                            Name = "Fatigue",
                            Status = true
                        },
                        new
                        {
                            Id = 13,
                            Name = "Heartburn/Indigestion",
                            Status = true
                        },
                        new
                        {
                            Id = 14,
                            Name = "Muscle Weakness",
                            Status = true
                        },
                        new
                        {
                            Id = 15,
                            Name = "Numbness or Tingling",
                            Status = true
                        },
                        new
                        {
                            Id = 16,
                            Name = "Shortness of breath",
                            Status = true
                        },
                        new
                        {
                            Id = 17,
                            Name = "Weight Gain",
                            Status = true
                        },
                        new
                        {
                            Id = 18,
                            Name = "Weight Loss",
                            Status = true
                        },
                        new
                        {
                            Id = 19,
                            Name = "Fainting",
                            Status = true
                        },
                        new
                        {
                            Id = 20,
                            Name = "Fever/Chills/Sweats",
                            Status = true
                        },
                        new
                        {
                            Id = 21,
                            Name = "Difficulty maintaining balance while walking",
                            Status = true
                        });
                });

            modelBuilder.Entity("Intake.API.Models.RefSugCondition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("RefSugConditions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Appendectomy",
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            Name = "Gallbladder Removal",
                            Status = true
                        },
                        new
                        {
                            Id = 3,
                            Name = "Hernia Repair",
                            Status = true
                        },
                        new
                        {
                            Id = 4,
                            Name = "Cataract Surgery",
                            Status = true
                        },
                        new
                        {
                            Id = 5,
                            Name = "Joint Replacement",
                            Status = true
                        });
                });

            modelBuilder.Entity("Intake.API.Models.SugCondition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("IntakeReference")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IntakeReference");

                    b.ToTable("SugConditions");
                });

            modelBuilder.Entity("Intake.API.Models.MedBodyParts", b =>
                {
                    b.HasOne("Intake.API.Models.MedicalIntake", "MedicalIntake")
                        .WithMany("BodyParts")
                        .HasForeignKey("IntakeReference")
                        .HasPrincipalKey("ReferenceNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicalIntake");
                });

            modelBuilder.Entity("Intake.API.Models.MedCondition", b =>
                {
                    b.HasOne("Intake.API.Models.MedicalIntake", "MedicalIntake")
                        .WithMany("MedConditions")
                        .HasForeignKey("IntakeReference")
                        .HasPrincipalKey("ReferenceNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicalIntake");
                });

            modelBuilder.Entity("Intake.API.Models.SugCondition", b =>
                {
                    b.HasOne("Intake.API.Models.MedicalIntake", "MedicalIntake")
                        .WithMany("SugConditions")
                        .HasForeignKey("IntakeReference")
                        .HasPrincipalKey("ReferenceNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicalIntake");
                });

            modelBuilder.Entity("Intake.API.Models.MedicalIntake", b =>
                {
                    b.Navigation("BodyParts");

                    b.Navigation("MedConditions");

                    b.Navigation("SugConditions");
                });
#pragma warning restore 612, 618
        }
    }
}
