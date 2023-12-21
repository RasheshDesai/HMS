using Hospital_Management_System.Models.BusinessLayer;

namespace Hospital_Management_System.Models.SQLOperation
{
    public interface IPatientService
    {
        List<Patient> GetPatientsRecords();

        public Patient GetPatientById(int id);

        public List<Patient> GetPatientByName(string name);
    }
}
