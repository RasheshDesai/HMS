namespace Hospital_Management_System.Models.BusinessLayer
{
    public enum Speciality
    {
        Neurologist,
        Cardiologist,
        OrthopedicSurgeon,
        Pediatrician,
        Psychiatrist,
        Dermatologist,
        Dentist
    }
    public class Doctor
    {
        public int DoctorID { get; set; }

        public string? DoctorName { get; set;}

        public Speciality Speciality { get; set;}
    }
}
