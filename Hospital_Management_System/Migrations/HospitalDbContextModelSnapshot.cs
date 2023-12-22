﻿// <auto-generated />
using System;
using Hospital_Management_System.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital_Management_System.Migrations
{
    [DbContext(typeof(HospitalDbContext))]
    partial class HospitalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("Hospital_Management_System.Models.BusinessLayer.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("AppointmentDesciption")
                        .HasColumnType("TEXT");

                    b.Property<int>("DoctorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PatientId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AppointmentId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Hospital_Management_System.Models.BusinessLayer.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BillDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("PatientId")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("TotalAmount")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Hospital_Management_System.Models.BusinessLayer.Doctor", b =>
                {
                    b.Property<int>("DoctorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DoctorName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Speciality")
                        .HasColumnType("INTEGER");

                    b.HasKey("DoctorID");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorID = 1,
                            DoctorName = "Elon Mask",
                            Speciality = 7
                        },
                        new
                        {
                            DoctorID = 2,
                            DoctorName = "Alice Heart",
                            Speciality = 2
                        },
                        new
                        {
                            DoctorID = 3,
                            DoctorName = "Michael Bones",
                            Speciality = 3
                        },
                        new
                        {
                            DoctorID = 4,
                            DoctorName = "Sarah Kiddo",
                            Speciality = 4
                        },
                        new
                        {
                            DoctorID = 5,
                            DoctorName = "David Mind",
                            Speciality = 5
                        },
                        new
                        {
                            DoctorID = 6,
                            DoctorName = "Grace Skin",
                            Speciality = 6
                        },
                        new
                        {
                            DoctorID = 7,
                            DoctorName = "Oliver Tooth",
                            Speciality = 7
                        },
                        new
                        {
                            DoctorID = 8,
                            DoctorName = "Lily Cardia",
                            Speciality = 2
                        },
                        new
                        {
                            DoctorID = 9,
                            DoctorName = "Jason Joints",
                            Speciality = 3
                        },
                        new
                        {
                            DoctorID = 10,
                            DoctorName = "Sophia Pediatric",
                            Speciality = 4
                        },
                        new
                        {
                            DoctorID = 11,
                            DoctorName = "Ethan Psyche",
                            Speciality = 5
                        },
                        new
                        {
                            DoctorID = 12,
                            DoctorName = "Emma Dermis",
                            Speciality = 6
                        },
                        new
                        {
                            DoctorID = 13,
                            DoctorName = "Noah Grin",
                            Speciality = 7
                        },
                        new
                        {
                            DoctorID = 14,
                            DoctorName = "Ava Heart",
                            Speciality = 2
                        },
                        new
                        {
                            DoctorID = 15,
                            DoctorName = "William Spine",
                            Speciality = 3
                        });
                });

            modelBuilder.Entity("Hospital_Management_System.Models.BusinessLayer.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MedicalRecord")
                        .HasColumnType("TEXT");

                    b.Property<string>("PatientName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("TEXT");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            PatientId = 1,
                            Address = "220 Burnhamthorpe Rd",
                            Description = "HighFever",
                            Gender = 1,
                            MedicalRecord = "None",
                            PatientName = "Rashesh",
                            PhoneNo = "6474277899"
                        },
                        new
                        {
                            PatientId = 2,
                            Address = "123 Elm Street",
                            Description = "Allergies",
                            Gender = 2,
                            MedicalRecord = "Allergy to peanuts",
                            PatientName = "Sarah",
                            PhoneNo = "555-1234"
                        },
                        new
                        {
                            PatientId = 3,
                            Address = "789 Oak Avenue",
                            Description = "Broken Arm",
                            Gender = 1,
                            MedicalRecord = "Fractured left arm",
                            PatientName = "Michael",
                            PhoneNo = "555-5678"
                        },
                        new
                        {
                            PatientId = 4,
                            Address = "456 Maple Drive",
                            Description = "Migraine",
                            Gender = 2,
                            MedicalRecord = "Chronic migraines",
                            PatientName = "Emily",
                            PhoneNo = "555-9876"
                        },
                        new
                        {
                            PatientId = 5,
                            Address = "111 Pine Lane",
                            Description = "Stomachache",
                            Gender = 1,
                            MedicalRecord = "Digestive issues",
                            PatientName = "Daniel",
                            PhoneNo = "555-5555"
                        },
                        new
                        {
                            PatientId = 6,
                            Address = "777 Cedar Road",
                            Description = "Sprained Ankle",
                            Gender = 2,
                            MedicalRecord = "Injured right ankle",
                            PatientName = "Olivia",
                            PhoneNo = "555-2222"
                        },
                        new
                        {
                            PatientId = 7,
                            Address = "222 Birch Street",
                            Description = "Concussion",
                            Gender = 1,
                            MedicalRecord = "Head injury",
                            PatientName = "William",
                            PhoneNo = "555-7777"
                        },
                        new
                        {
                            PatientId = 8,
                            Address = "333 Oak Drive",
                            Description = "Asthma",
                            Gender = 2,
                            MedicalRecord = "Asthma diagnosis",
                            PatientName = "Sophia",
                            PhoneNo = "555-3333"
                        },
                        new
                        {
                            PatientId = 9,
                            Address = "444 Elm Avenue",
                            Description = "Fever",
                            Gender = 1,
                            MedicalRecord = "Unknown fever cause",
                            PatientName = "Noah",
                            PhoneNo = "555-4444"
                        },
                        new
                        {
                            PatientId = 10,
                            Address = "555 Pine Street",
                            Description = "Flu",
                            Gender = 2,
                            MedicalRecord = "Influenza diagnosis",
                            PatientName = "Ava",
                            PhoneNo = "555-8888"
                        });
                });

            modelBuilder.Entity("Hospital_Management_System.Models.BusinessLayer.Records", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double?>("BillAmount")
                        .HasColumnType("REAL");

                    b.Property<int>("DoctorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PatientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Results")
                        .HasColumnType("TEXT");

                    b.HasKey("RecordId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("MedicalRecords");
                });

            modelBuilder.Entity("Hospital_Management_System.Models.BusinessLayer.Appointment", b =>
                {
                    b.HasOne("Hospital_Management_System.Models.BusinessLayer.Doctor", "DoctorName")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital_Management_System.Models.BusinessLayer.Patient", "PatientName")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DoctorName");

                    b.Navigation("PatientName");
                });

            modelBuilder.Entity("Hospital_Management_System.Models.BusinessLayer.Bill", b =>
                {
                    b.HasOne("Hospital_Management_System.Models.BusinessLayer.Patient", "PatientName")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PatientName");
                });

            modelBuilder.Entity("Hospital_Management_System.Models.BusinessLayer.Records", b =>
                {
                    b.HasOne("Hospital_Management_System.Models.BusinessLayer.Doctor", "DoctorName")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital_Management_System.Models.BusinessLayer.Patient", "PatientName")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DoctorName");

                    b.Navigation("PatientName");
                });
#pragma warning restore 612, 618
        }
    }
}
