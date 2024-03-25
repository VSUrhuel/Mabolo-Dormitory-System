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
            // Arrange
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

            // Act
            User user = new User(userId, firstName, lastName, birthday, email, phoneNumber, address, userStatus, userType, fkDepartmentId);

            // Assert
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
        }

        [Fact]
        public static void User_ToString_ReturnsFormattedString()
        {
            // Arrange
            string userId = "user123";
            string firstName = "John";
            string lastName = "Doe";

            // Act
            User user = new User(userId, firstName, lastName, DateTime.Now, "", "", "", "", "", 0);
            string actualString = user.ToString();

            // Assert
            string expectedString = userId + ": " + firstName + " " + lastName;
            Assert.Equal(expectedString, actualString);
        }
    }
}
