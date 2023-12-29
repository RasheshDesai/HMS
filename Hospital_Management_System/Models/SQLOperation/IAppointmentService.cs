using Hospital_Management_System.Models.BusinessLayer;

namespace Hospital_Management_System.Models.SQLOperation
{
    public interface IAppointmentService
    {
        List<Appointment> GetAllAppointments();

        Appointment GetAppointmentById(int id);

        Appointment CreateAppointment(int PatientId,int doctorId,Appointment appointment);

        Appointment UpdateAppointment(Appointment appointment);

        Appointment DeleteAppointment(int id);


    }
}
