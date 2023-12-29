using Hospital_Management_System.Models.BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Management_System.Models.DataSeed
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasData(
                    new Patient { PatientId = 1, PatientName = "Rashesh", Gender = Gender.Male, Address = "220 Burnhamthorpe Rd", PhoneNo = "6474277899", Description = "HighFever", MedicalRecord = "None" },
                    new Patient { PatientId = 2, PatientName = "Sarah", Gender = Gender.Female, Address = "123 Elm Street", PhoneNo = "555-1234", Description = "Allergies", MedicalRecord = "Allergy to peanuts" },
                    new Patient { PatientId = 3, PatientName = "Michael", Gender = Gender.Male, Address = "789 Oak Avenue", PhoneNo = "555-5678", Description = "Broken Arm", MedicalRecord = "Fractured left arm" },
                    new Patient { PatientId = 4, PatientName = "Emily", Gender = Gender.Female, Address = "456 Maple Drive", PhoneNo = "555-9876", Description = "Migraine", MedicalRecord = "Chronic migraines" },
                    new Patient { PatientId = 5, PatientName = "Daniel", Gender = Gender.Male, Address = "111 Pine Lane", PhoneNo = "555-5555", Description = "Stomachache", MedicalRecord = "Digestive issues" },
                    new Patient { PatientId = 6, PatientName = "Olivia", Gender = Gender.Female, Address = "777 Cedar Road", PhoneNo = "555-2222", Description = "Sprained Ankle", MedicalRecord = "Injured right ankle" },
                    new Patient { PatientId = 7, PatientName = "William", Gender = Gender.Male, Address = "222 Birch Street", PhoneNo = "555-7777", Description = "Concussion", MedicalRecord = "Head injury" },
                    new Patient { PatientId = 8, PatientName = "Sophia", Gender = Gender.Female, Address = "333 Oak Drive", PhoneNo = "555-3333", Description = "Asthma", MedicalRecord = "Asthma diagnosis" },
                    new Patient { PatientId = 9, PatientName = "Noah", Gender = Gender.Male, Address = "444 Elm Avenue", PhoneNo = "555-4444", Description = "Fever", MedicalRecord = "Unknown fever cause" },
                    new Patient { PatientId = 10, PatientName = "Ava", Gender = Gender.Female, Address = "555 Pine Street", PhoneNo = "555-8888", Description = "Flu", MedicalRecord = "Influenza diagnosis" }
                );

            modelBuilder.Entity<Doctor>().HasData(
                     new Doctor { DoctorID = 1, DoctorName = "Elon Mask", Speciality = Speciality.Dentist },
                     new Doctor { DoctorID = 2, DoctorName = "Alice Heart", Speciality = Speciality.Cardiologist },
                     new Doctor { DoctorID = 3, DoctorName = "Michael Bones", Speciality = Speciality.OrthopedicSurgeon },
                     new Doctor { DoctorID = 4, DoctorName = "Sarah Kiddo", Speciality = Speciality.Pediatrician },
                     new Doctor { DoctorID = 5, DoctorName = "David Mind", Speciality = Speciality.Psychiatrist },
                     new Doctor { DoctorID = 6, DoctorName = "Grace Skin", Speciality = Speciality.Dermatologist },
                     new Doctor { DoctorID = 7, DoctorName = "Oliver Tooth", Speciality = Speciality.Dentist },
                     new Doctor { DoctorID = 8, DoctorName = "Lily Cardia", Speciality = Speciality.Cardiologist },
                     new Doctor { DoctorID = 9, DoctorName = "Jason Joints", Speciality = Speciality.OrthopedicSurgeon },
                     new Doctor { DoctorID = 10, DoctorName = "Sophia Pediatric", Speciality = Speciality.Pediatrician },
                     new Doctor { DoctorID = 11, DoctorName = "Ethan Psyche", Speciality = Speciality.Psychiatrist },
                     new Doctor { DoctorID = 12, DoctorName = "Emma Dermis", Speciality = Speciality.Dermatologist },
                     new Doctor { DoctorID = 13, DoctorName = "Noah Grin", Speciality = Speciality.Dentist },
                     new Doctor { DoctorID = 14, DoctorName = "Ava Heart", Speciality = Speciality.Cardiologist },
                     new Doctor { DoctorID = 15, DoctorName = "William Spine", Speciality = Speciality.OrthopedicSurgeon }
                );
            /*
                modelBuilder.Entity<Appointment>().HasData(
                    new Appointment { AppointmentId = 1, AppointmentDate= new DateTime(), PatientId=1,PatientName =  }
                );

            */
        }
    }
}
