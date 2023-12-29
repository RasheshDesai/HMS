using Hospital_Management_System.Database;
using Hospital_Management_System.Models.BusinessLayer;
using Hospital_Management_System.Models.SQLOperation;

namespace Hospital_Management_System.Service
{
    public class PatientService : IPatientService
    {
        public readonly HospitalDbContext _context;

        public PatientService(HospitalDbContext context)
        {
            _context = context;
        }

        public Patient AddPatient(Patient patient)
        {
            _context.Patients.Add(patient);
            _context.SaveChanges();
            return patient;
        }

        public Patient GetPatientById(int id)
        {

            return _context.Patients.Find(id)!;
        }

        public List<Patient> GetPatientByName(string name)
        {
            var patientName = _context.Patients.Where(patient => patient.PatientName == name).ToList();

            return patientName;
        }

        public List<Patient> GetPatientsRecords()
        {
            List<Patient> records = _context.Patients.ToList();
            return records;
        }

        public Patient UpdatePatient(Patient patient)
        {
            var p = _context.Patients.Attach(patient);
            p.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return patient;
        }

        public string DeletePatient(int id) 
        {
            Patient patient = _context.Patients.Find(id)!;
            
            if(patient != null)
            {
				_context.Patients.Remove(patient);
				_context.SaveChanges();
			}
            
            return "Patient Removed";
                
        }
    }
}
