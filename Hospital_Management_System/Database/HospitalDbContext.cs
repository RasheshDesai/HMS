using Hospital_Management_System.Models.BusinessLayer;
using Hospital_Management_System.Models.DataSeed;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Management_System.Database
{
    public class HospitalDbContext : DbContext
    {

        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }

        

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<Bill> Bills { get; set; }  

        public DbSet<Records> MedicalRecords {  get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }


    }

    
}
