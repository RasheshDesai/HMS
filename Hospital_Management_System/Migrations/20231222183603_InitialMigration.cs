using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DoctorName = table.Column<string>(type: "TEXT", nullable: true),
                    Speciality = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorID);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PatientName = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNo = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    MedicalRecord = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AppointmentDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PatientId = table.Column<int>(type: "INTEGER", nullable: false),
                    DoctorId = table.Column<int>(type: "INTEGER", nullable: false),
                    AppointmentDesciption = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PatientId = table.Column<int>(type: "INTEGER", nullable: false),
                    BillDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TotalAmount = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalRecords",
                columns: table => new
                {
                    RecordId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PatientId = table.Column<int>(type: "INTEGER", nullable: false),
                    DoctorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Results = table.Column<string>(type: "TEXT", nullable: true),
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    BillAmount = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRecords", x => x.RecordId);
                    table.ForeignKey(
                        name: "FK_MedicalRecords_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalRecords_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorID", "DoctorName", "Speciality" },
                values: new object[,]
                {
                    { 1, "Elon Mask", 7 },
                    { 2, "Alice Heart", 2 },
                    { 3, "Michael Bones", 3 },
                    { 4, "Sarah Kiddo", 4 },
                    { 5, "David Mind", 5 },
                    { 6, "Grace Skin", 6 },
                    { 7, "Oliver Tooth", 7 },
                    { 8, "Lily Cardia", 2 },
                    { 9, "Jason Joints", 3 },
                    { 10, "Sophia Pediatric", 4 },
                    { 11, "Ethan Psyche", 5 },
                    { 12, "Emma Dermis", 6 },
                    { 13, "Noah Grin", 7 },
                    { 14, "Ava Heart", 2 },
                    { 15, "William Spine", 3 }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "Address", "Description", "Gender", "MedicalRecord", "PatientName", "PhoneNo" },
                values: new object[,]
                {
                    { 1, "220 Burnhamthorpe Rd", "HighFever", 1, "None", "Rashesh", "6474277899" },
                    { 2, "123 Elm Street", "Allergies", 2, "Allergy to peanuts", "Sarah", "555-1234" },
                    { 3, "789 Oak Avenue", "Broken Arm", 1, "Fractured left arm", "Michael", "555-5678" },
                    { 4, "456 Maple Drive", "Migraine", 2, "Chronic migraines", "Emily", "555-9876" },
                    { 5, "111 Pine Lane", "Stomachache", 1, "Digestive issues", "Daniel", "555-5555" },
                    { 6, "777 Cedar Road", "Sprained Ankle", 2, "Injured right ankle", "Olivia", "555-2222" },
                    { 7, "222 Birch Street", "Concussion", 1, "Head injury", "William", "555-7777" },
                    { 8, "333 Oak Drive", "Asthma", 2, "Asthma diagnosis", "Sophia", "555-3333" },
                    { 9, "444 Elm Avenue", "Fever", 1, "Unknown fever cause", "Noah", "555-4444" },
                    { 10, "555 Pine Street", "Flu", 2, "Influenza diagnosis", "Ava", "555-8888" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_PatientId",
                table: "Bills",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_DoctorId",
                table: "MedicalRecords",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_PatientId",
                table: "MedicalRecords",
                column: "PatientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "MedicalRecords");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
