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
    [Migration("20240606130715_step 3")]
    partial class step3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.4.24267.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.Property<string>("Allergies")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CellNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LatexSensitive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaritalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalLegalCase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pregnant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Smoke")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkRestriction")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MedicalIntakes");
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
#pragma warning restore 612, 618
        }
    }
}
