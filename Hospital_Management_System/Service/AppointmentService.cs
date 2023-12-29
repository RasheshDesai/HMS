using Hospital_Management_System.Database;
using Hospital_Management_System.Models.BusinessLayer;
using Hospital_Management_System.Models.SQLOperation;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Management_System.Service
{
    public class AppointmentService : IAppointmentService
    {
        private readonly HospitalDbContext context;

        public AppointmentService(HospitalDbContext context) 
        {
            this.context = context;
        }
        public Appointment CreateAppointment(int patientId,int doctorId, Appointment newAppointment)
        {
            Patient loggedInPatient = context.Patients.FirstOrDefault(x => x.PatientId == patientId);
            Doctor doctor = context.Doctors.FirstOrDefault(x => x.DoctorID == doctorId);
            /*
            if (loggedInPatient == null || doctor == null)
            {
                throw new InvalidOperationException("Patient or Doctor not found");
            }
            */
            newAppointment.PatientId = loggedInPatient.PatientId;
            //newAppointment.PatientName = loggedInPatient.PatientName;
            newAppointment.DoctorId = doctor.DoctorID;
            //newAppointment.DoctorName = doctor.DoctorName;

            Appointment appointment = context.Appointments.FirstOrDefault(); // Retrieving an appointment from the context
            if (appointment != null)
            {
                // Accessing the associated Patient entity through the PatientName navigation property
                Patient associatedPatient = appointment.PatientName;
                Doctor associatedDocter = appointment.DoctorName;
            }

            context.Appointments.Add(newAppointment);
            context.SaveChanges();
            return newAppointment;
        }

        public Appointment DeleteAppointment(int id)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetAllAppointments()
        {
            var appointments = context.Appointments
             .Include(a => a.PatientName) // Include Patient navigation property
             .Include(a => a.DoctorName) // Include Doctor navigation property
             .ToList(); // Fetch appointments along with associated patients and doctors

            return appointments;
        }

        public Appointment GetAppointmentById(int id)
        {
            throw new NotImplementedException();
        }

        public Appointment UpdateAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
        }
    }

}
