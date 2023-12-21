using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_Management_System.Models.BusinessLayer
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        public DateTime AppointmentDate { get; set; }

        [ForeignKey("Patients")]
        public int PatientId { get; set; }

        public virtual Patient? PatientName { get; set; }

        [ForeignKey("Doctors")]
        public int DoctorId { get; set; }

        public virtual Doctor? DoctorName { get; set; }

        
        public string? AppointmentDesciption { get; set; }

    }
}
