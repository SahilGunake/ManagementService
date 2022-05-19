using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementService
{
    public class StaffRepository : IStaffRepository
    {
        public static readonly List<Staff> staffList = new List<Staff>()
        {
            new Staff {Id=101, FirstName="John", LastName="Doe", EmailId="johndoe@dm.com", Address="Scranton, USA", MobileNo=7896541231, DateOfBirth=Convert.ToDateTime("05/30/2000"), DateOfJoining=Convert.ToDateTime("05/30/2022"), Salary=5000, IsAdmin=false, Password="John@123"},
            new Staff {Id=102, FirstName="Tony", LastName="Stark", EmailId="tonystark@dm.com", Address="New York, USA", MobileNo=7896541231, DateOfBirth=Convert.ToDateTime("05/30/2000"), DateOfJoining=Convert.ToDateTime("05/30/2022"), Salary=5000, IsAdmin=true, Password="John@123"},
            new Staff {Id=103, FirstName="Jim", LastName="Halphert", EmailId="jimhalph@dm.com", Address="Scranton, USA", MobileNo=7896541231, DateOfBirth=Convert.ToDateTime("05/30/2000"), DateOfJoining=Convert.ToDateTime("05/30/2022"), Salary=5000, IsAdmin=false, Password="John@123"},
            new Staff {Id=104, FirstName="Steve", LastName="Rogers", EmailId="steverog@dm.com", Address="Washington DC, USA", MobileNo=7896541231, DateOfBirth=Convert.ToDateTime("05/30/2000"), DateOfJoining=Convert.ToDateTime("05/30/2022"), Salary=5000, IsAdmin=true, Password="John@123"},
           
        };

        public async Task<Staff> DeleteStaff(int staffId)
        {
            var staff = staffList.SingleOrDefault(v => v.Id == staffId);
            if (staff != null)
            {
                staffList.Remove(staff);
            }
            return staff;
        }

        public async Task<Staff> GetStaffByID(int staff)
        {
            return staffList.SingleOrDefault(v => v.Id == staff);
        }

        public async Task<IEnumerable<Staff>> GetStaff()
        {
            return staffList;
        }

        public async Task<Staff> InsertStaff(Staff staff)
        {
            staffList.Add(staff);
            return staff;
        }

        public async Task<Staff> UpdateStaff(Staff staff)
        {
            var staf = staffList.SingleOrDefault(m => m.Id == staff.Id);

            if (staf != null)
            {
                staf.FirstName = staff.FirstName;
                staf.LastName = staff.LastName;
                staf.EmailId = staff.EmailId;
                staf.MobileNo = staff.MobileNo;
                staf.Address = staff.Address;
                staf.Salary = staff.Salary;
                staf.IsAdmin = staff.IsAdmin;

                return staf;
            }

            return null;
        }
    
    }
}
