using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabolo_Dormitory_System.Classes
{
    public class User
    {
        public String UserId { get; private set; }
        public String FirstName { get; private set; }
        public String LastName { get; private set; }
        public DateTime Birthday { get; private set; }
        public String Email { get; private set; }
        public String PhoneNumber { get; private set; } 
        public String Address { get; private set; }
        public String UserStatus { get; private set; }
        public String UserType { get; private set; }
        public int FK_DepartmentId { get; private set; }
        
        public User (String userId, String firstName, String lastName, DateTime birthday, String email, String phoneNumber, String address, String userStatus, String userType, int fk_departmentId)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            UserStatus = userStatus;
            UserType = userType;
            FK_DepartmentId = fk_departmentId;
        }

        public override string ToString()
        {
            return UserId + ": " + FirstName + " " + LastName;
        }
    }
}
