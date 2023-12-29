using Hospital_Management_System.Models.BusinessLayer;

namespace Hospital_Management_System.Models.SQLOperation
{
    public interface IDoctorService
    {
        List<Doctor> GetDoctorsRecord();

        public Doctor CreateDoctor(Doctor doctor);
        public List<Doctor> GetDoctorByName(string name);
        List<Doctor> GetDoctorBySpeciality(Speciality speciality);

        Doctor UpdateDoctor(Doctor doctor);
        string DeleteDoctor(int id);
    }
}
