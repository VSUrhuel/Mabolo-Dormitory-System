using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabolo_Dormitory_System.Classes
{
    public class Account
    {
        public String Email { get; private set; }
        public String UserName { get; private set; }
        public String Password { get; private set; }
        public DateTime Birthday { get; private set; }
        public String FirstName { get; private set; }
        public String LastName { get; private set; }
        public Byte[] ImageData { get; private set; }

        public Account(String email, String userName, String password, DateTime birthday, String firstName, String lastName, byte[] imageDate)
        {
            ValidateArguments(email, userName, password, birthday, firstName, lastName);
            if (ValidationClass.ValidateEmail(email) == false)
            {
                throw new ArgumentException("Invalid email");
            }
            if (ValidationClass.ValidatePassword(password) == false)
            {
                throw new ArgumentException("Invalid password");
            }
            Email = email;
            UserName = userName;
            Password = password;
            Birthday = birthday;
            FirstName = firstName;
            LastName = lastName;
            ImageData = imageDate;
        }

        private void ValidateArguments (String email, String userName, String password, DateTime birthday, String firstName, String lastName)
        {
            if (email == null || email.Length == 0)
            {
                throw new ArgumentException("Email cannot be null or empty");
            }
            if (userName == null || userName.Length == 0)
            {
                throw new ArgumentException("Username cannot be null or empty");
            }
            if (password == null || password.Length == 0)
            {
                throw new ArgumentException("Password cannot be null or empty");
            }
            if (birthday == null)
            {
                throw new ArgumentException("Birthday cannot be null");
            }
            if (firstName == null || firstName.Length == 0)
            {
                throw new ArgumentException("First name cannot be null or empty");
            }
            if (lastName == null || lastName.Length == 0)
            {
                throw new ArgumentException("Last name cannot be null or empty");
            }
        }
    }
}
