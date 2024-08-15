using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mabolo_Dormitory_System.Classes;
using Xunit;

namespace Mabolo_Dormitory_System.Unit_Test_Classes
{
    public class TestUser
    {
       
        [Fact]
        public static void User_Constructor_SetsPropertiesCorrectly()
        {
            string userId = "user13";
            string firstName = "John";
            string lastName = "Doe";
            DateTime birthday = new DateTime(1990, 1, 1);
            string email = "john.doe@example.com";
            string phoneNumber = "123-456-7890";
            string address = "123 Main St";
            string userStatus = "Active";
            string userType = "Employee";
            int fkDepartmentId = 1;
            int availWifi = 1;

            User user = new User(userId, firstName, lastName, birthday, email, phoneNumber, address, availWifi, 1, 1, userStatus, userType, fkDepartmentId);

            Assert.Equal(userId, user.UserId);
            Assert.Equal(firstName, user.FirstName);
            Assert.Equal(lastName, user.LastName);
            Assert.Equal(birthday, user.Birthday);
            Assert.Equal(email, user.Email);
            Assert.Equal(phoneNumber, user.PhoneNumber);
            Assert.Equal(address, user.Address);
            Assert.Equal(userStatus, user.UserStatus);
            Assert.Equal(userType, user.UserType);
            Assert.Equal(fkDepartmentId, user.FK_DepartmentId);
            Assert.Equal(availWifi, user.AvailWiFi);
        }

        [Fact]
        public void User_Constructor_ThrowsArgumentNullException_ForNullUserId()
        {
            string firstName = "John";
            string lastName = "Doe";
            DateTime birthday = new DateTime(1990, 1, 1);
            string email = "john.doe@example.com";
            string phoneNumber = "123-456-7890";
            string address = "123 Main St";
            string userStatus = "Active";
            string userType = "Regular Dormer";
            int fkDepartmentId = 1;
            int availWiFi = 1;

            Assert.Throws<ArgumentNullException>(() => new User(null, firstName, lastName, birthday, email, phoneNumber, address, availWiFi, 1, 1, userStatus, userType, fkDepartmentId));
        }

        [Fact]
        public void User_Constructor_ThrowsArgumentOutOfRangeException_ForNegativeFKDepartmentId()
        {
            string userId = "user13";
            string firstName = "John";
            string lastName = "Doe";
            DateTime birthday = new DateTime(1990, 1, 1);
            string email = "john.doe@example.com";
            string phoneNumber = "123-456-7890";
            string address = "123 Main St";
            string userStatus = "Active";
            string userType = "Regular Dormer";
            int availWiFi = 1;

            Assert.Throws<ArgumentOutOfRangeException>(() => new User(userId, firstName, lastName, birthday, email, phoneNumber, address, 1, 1, availWiFi, userStatus, userType, -1));
        }

        [Fact]
        public void User_Constructor_InvalidEmail()
        {
            string userId = "user13";
            string firstName = "John";
            string lastName = "Doe";
            DateTime birthday = new DateTime(1990, 1, 1);
            string email = "invalidemail";
            string phoneNumber = "123-456-7890";
            string address = "123 Main St";
            string userStatus = "Active";
            string userType = "Regular Dormer";
            int availWiFi = 1;

            Assert.Throws<ArgumentException>(() => new User(userId, firstName, lastName, birthday, email, phoneNumber, address, availWiFi, 1, 1, userStatus, userType, 1));
        }

        [Fact]
        public void User_ToString_ReturnsFormattedString()
        {
            string userId = "user13";
            string firstName = "John";
            string lastName = "Doe";
            DateTime birthday = new DateTime(1990, 1, 1);
            string email = "john.doe@example.com";
            string phoneNumber = "123-456-7890";
            string address = "123 Main St";
            string userStatus = "Active";
            string userType = "Regular Dormer";
            int fkDepartmentId = 1;
            int availWiFi = 1;

            User user = new User(userId, firstName, lastName, birthday, email, phoneNumber, address, availWiFi,  1, 1, userStatus, userType, fkDepartmentId);

            string actualString = user.ToString();

            Assert.Equal($"{userId}: {firstName} {lastName}", actualString);
        }
    }
}
