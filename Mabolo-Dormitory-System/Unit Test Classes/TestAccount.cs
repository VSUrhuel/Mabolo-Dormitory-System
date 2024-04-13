using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mabolo_Dormitory_System.Classes;
using Moq;
using Xunit;

namespace Mabolo_Dormitory_System.Unit_Test_Classes
{
    public class TestAccount
    {
        public class AccountTest
        {
            [Fact]
            public void Test_Constructor_NegativeAccountId()
            {
                // Arrange
                int accountId = -1;
                string userName = "TestUser";
                string password = "ValidPass123";
                string fK_UserId_Account = "FK123";
                byte[] imageData = new byte[] { 0x01, 0x02, 0x03 };

                // Act & Assert (expect ArgumentOutOfRangeException)
                Assert.Throws<ArgumentOutOfRangeException>(() => new Account(accountId, userName, password, fK_UserId_Account, imageData));
            }

            [Fact]
            public void Test_Constructor_NullUserName()
            {
                // Arrange
                int accountId = 1;
                string userName = null;
                string password = "ValidPass123";
                string fK_UserId_Account = "FK123";
                byte[] imageData = new byte[] { 0x01, 0x02, 0x03 };

                // Act & Assert (expect ArgumentNullException)
                Assert.Throws<ArgumentNullException>(() => new Account(accountId, userName, password, fK_UserId_Account, imageData));
            }

            [Fact]
            public void Test_Constructor_EmptyUserName()
            {
                // Arrange
                int accountId = 1;
                string userName = "";
                string password = "ValidPass123";
                string fK_UserId_Account = "FK123";
                byte[] imageData = new byte[] { 0x01, 0x02, 0x03 };

                // Act & Assert (expect ArgumentNullException)
                Assert.Throws<ArgumentNullException>(() => new Account(accountId, userName, password, fK_UserId_Account, imageData));
            }

            [Fact]
            public void Test_Constructor_NullPassword()
            {
                // Arrange
                int accountId = 1;
                string userName = "TestUser";
                string password = null;
                string fK_UserId_Account = "FK123";
                byte[] imageData = new byte[] { 0x01, 0x02, 0x03 };

                // Act & Assert (expect ArgumentNullException)
                Assert.Throws<ArgumentNullException>(() => new Account(accountId, userName, password, fK_UserId_Account, imageData));
            }

            [Fact]
            public void Test_Constructor_EmptyPassword()
            {
                // Arrange
                int accountId = 1;
                string userName = "TestUser";
                string password = "";
                string fK_UserId_Account = "FK123";
                byte[] imageData = new byte[] { 0x01, 0x02, 0x03 };

                // Act & Assert (expect ArgumentNullException)
                Assert.Throws<ArgumentNullException>(() => new Account(accountId, userName, password, fK_UserId_Account, imageData));
            }

            [Fact]
            public void Test_Constructor_NullFK_UserId_Account()
            {
                // Arrange
                int accountId = 1;
                string userName = "TestUser";
                string password = "ValidPass123";
                string fK_UserId_Account = null;
                byte[] imageData = new byte[] { 0x01, 0x02, 0x03 };

                // Act & Assert (expect ArgumentNullException)
                Assert.Throws<ArgumentNullException>(() => new Account(accountId, userName, password, fK_UserId_Account, imageData));
            }

            [Fact]
            public void Test_Constructor_EmptyFK_UserId_Account()
            {
                // Arrange
                int accountId = 1;
                string userName = "TestUser";
                string password = "ValidPass123";
                string fK_UserId_Account = "";
                byte[] imageData = new byte[] { 0x01, 0x02, 0x03 };

                // Act & Assert (expect ArgumentNullException)
                Assert.Throws<ArgumentNullException>(() => new Account(accountId, userName, password, fK_UserId_Account, imageData));
            }
            [Fact] 

            // ... Continue with previous tests ...

            public void Test_Constructor_NullImageData()
            {
                // Arrange
                int accountId = 1;
                string userName = "TestUser";
                string password = "ValidPass123";
                string fK_UserId_Account = "FK123";
                byte[] imageData = null;

                // Act & Assert (expect ArgumentNullException)
                Assert.Throws<ArgumentNullException>(() => new Account(accountId, userName, password, fK_UserId_Account, imageData));
            }

    
        }
    }
}

