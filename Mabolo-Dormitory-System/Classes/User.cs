using Microsoft.VisualStudio.TestPlatform.ObjectModel;
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
        public int AvailWiFi {  get; private set; }
        public int HasLaptop { get; private set; }
        public int HasPrinter { get; private set; } 
        public String UserStatus { get; private set; }
        public String UserType { get; private set; }
        public int FK_DepartmentId { get; private set; }

        public User (String userId, String firstName, String lastName, DateTime birthday, String email, String phoneNumber, String address, int availWiFi, int hasLaptop, int hasPrinter, String userStatus, String userType, int fk_departmentId)
        {
            ValidateArg(userId, firstName, lastName, birthday, email, phoneNumber, address, userStatus, userType, fk_departmentId);
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            UserStatus = userStatus;
            UserType = userType;
            AvailWiFi = availWiFi;
            HasLaptop = hasLaptop;
            HasPrinter = hasPrinter;
            FK_DepartmentId = fk_departmentId;
        }

        private void ValidateArg(String userId, String firstName, String lastName, DateTime birthday, String email, String phoneNumber, String address, String userStatus, String userType, int fk_departmentId)
        {
            if (userId == null || userId.Length == 0)
                throw new ArgumentNullException();
            if (firstName == null || firstName.Length == 0)
                throw new ArgumentNullException();
            if (lastName == null || lastName.Length == 0)
                throw new ArgumentNullException();
            if (email == null || email.Length == 0)
                throw new ArgumentNullException();
            if (phoneNumber == null || phoneNumber.Length == 0)
                throw new ArgumentNullException();
            if (address == null || address.Length == 0)
                throw new ArgumentNullException();
            if (userStatus == null || userStatus.Length == 0)
                throw new ArgumentNullException();
            if (userType == null || userType.Length == 0)
                throw new ArgumentNullException();
            if (fk_departmentId < 0)
                throw new ArgumentOutOfRangeException();
            if(ValidationClass.ValidateEmail(email) == false)
                throw new ArgumentException();
        }

        public override string ToString()
        {
            return UserId + ": " + FirstName + " " + LastName;
        }
    }
}
