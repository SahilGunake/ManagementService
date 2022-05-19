using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManagementService
{
    public interface IStaffRepository
    {
        Task<IEnumerable<Staff>> GetStaff();
        Task<Staff> GetStaffByID(int staff);
        Task<Staff> InsertStaff(Staff staff);
        Task<Staff> DeleteStaff(int staffId);
        Task<Staff> UpdateStaff(Staff staff);
    }
}
