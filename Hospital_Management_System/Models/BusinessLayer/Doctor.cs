using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_System.Models.BusinessLayer
{
    public enum Speciality
    {
        Neurologist = 1,
        Cardiologist,
        OrthopedicSurgeon,
        Pediatrician,
        Psychiatrist,
        Dermatologist,
        Dentist
    }
    public class Doctor
    {
        [Key]
        public int DoctorID { get; set; }

        public string? DoctorName { get; set;}

        [Required(ErrorMessage = "Please specify your Doctor's Specialization")]
        public Speciality Speciality { get; set;}
    }
}
