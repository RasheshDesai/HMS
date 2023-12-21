using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_Management_System.Models.BusinessLayer
{
    public class Bill
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Patients")]
        public int PatientId { get; set; }

        public virtual Patient? PatientName { get; set; }
        public DateTime BillDate { get; set; }

          

        public double? TotalAmount { get; set; }
    }
}
