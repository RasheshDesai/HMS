using Hospital_Management_System.Database;
using Hospital_Management_System.Models.BusinessLayer;
using Hospital_Management_System.Models.SQLOperation;

namespace Hospital_Management_System.Service
{
    public class DoctorsService : IDoctorService
    {
        public readonly HospitalDbContext _context;

        public DoctorsService(HospitalDbContext context)
        {
            _context = context;
        }

        public Doctor CreateDoctor(Doctor doctor)
        {
            _context.Add(doctor);
            _context.SaveChanges();
            return doctor;
        }

        public Doctor GetDoctorByName()
        {
            throw new NotImplementedException();
        }

        public List<Doctor> GetDoctorBySpeciality(string speciality)
        {
            throw new NotImplementedException();
        }

        public List<Doctor> GetDoctorsRecord()
        {
            List<Doctor> doctors = _context.Doctors.ToList();
            return doctors;
        }
    }
}
