using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_Management_System.Models.BusinessLayer
{
    public class Records
    {
        [Key]
        public int RecordId {  get; set; }

        [ForeignKey("Patients")]
        public int PatientId { get; set; }

        public virtual Patient? PatientName { get; set; }

      //  public virtual Patient? PatientDesciption { get; set; }

        [ForeignKey("Doctors")]
        public int DoctorId { get; set; }

        public virtual Doctor? DoctorName { get; set; }


        public string? Results { get; set; }

        [ForeignKey("Bills")]
        public int Id { get; set; }

        public double? BillAmount { get; set; }
    }
}
