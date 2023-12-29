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

        public string DeleteDoctor(int id)
        {
            var findDoctor = _context.Doctors.Find(id)!;
            if(findDoctor != null) 
            {
                _context.Remove(findDoctor);
                _context.SaveChanges();

            }
           
            return "Doctor Deleted";
        }

        public List<Doctor> GetDoctorByName(string name)
        {
            List<Doctor> list = _context.Doctors.Where(d => d.DoctorName == name).ToList();
            return list;

        }

        public List<Doctor> GetDoctorBySpeciality(Speciality speciality)
        {
            return _context.Doctors.Where(d=> d.Speciality == speciality).ToList();  
        }

        public List<Doctor> GetDoctorsRecord()
        {
            List<Doctor> doctors = _context.Doctors.ToList();
            return doctors;
        }

        public Doctor UpdateDoctor(Doctor doctor)
        {

            var d = _context.Doctors.Attach(doctor);
            d.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return doctor;
        }
    }
}
