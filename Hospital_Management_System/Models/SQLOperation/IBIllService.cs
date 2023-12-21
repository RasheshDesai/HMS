using Hospital_Management_System.Models.BusinessLayer;

namespace Hospital_Management_System.Models.SQLOperation
{
    public interface IBIllService
    {
        Bill GetBillDetailsById(int id);
    }
}
