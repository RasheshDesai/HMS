using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_System.Models.BusinessLayer
{
    public enum Gender
    {
        Male=1,
        Female,
        Other
    }
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        public string? PatientName { get; set; }

        public Gender Gender { get; set; } 
        public string? Address { get; set; }

        public string? PhoneNo { get; set; }

        public string? Description { get; set; }

        public string? MedicalRecord { get; set; }

    }
}
