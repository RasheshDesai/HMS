using Hospital_Management_System.Models.BusinessLayer;

namespace Hospital_Management_System.Models.SQLOperation
{
    public interface IDoctorService
    {
        List<Doctor> GetDoctorsRecord();

        public Doctor GetDoctorByName();
        List<Doctor> GetDoctorBySpeciality(string  speciality);
    }
}
