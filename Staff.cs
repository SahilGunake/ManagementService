using System;

namespace ManagementService
{
    public class Staff
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String EmailId { get; set; }
        public String Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfJoining { get; set; }
        public long MobileNo { get; set; }
        public String Address { get; set; }
        public bool IsAdmin { get; set; }
        public double Salary { get; set; }

    }
}
