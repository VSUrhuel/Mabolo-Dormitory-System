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
                int accountId = -1;
                string userName = "TestUser";
                string password = "ValidPass123@";
                string fK_UserId_Account = "FK123";
                byte[] imageData = new byte[] { 0x01, 0x02, 0x03 };

                Assert.Throws<ArgumentOutOfRangeException>(() => new Account(accountId, userName, password, fK_UserId_Account, imageData));
            }

            [Fact]
            public void Test_Constructor_NullUserName()
            {
                int accountId = 1;
                string userName = null;
                string password = "ValidPass123";
                string fK_UserId_Account = "FK123";
                byte[] imageData = new byte[] { 0x01, 0x02, 0x03 };

                Assert.Throws<ArgumentNullException>(() => new Account(accountId, userName, password, fK_UserId_Account, imageData));
            }

            [Fact]
            public void Test_Constructor_EmptyUserName()
            {
                int accountId = 1;
                string userName = "";
                string password = "ValidPass123@";
                string fK_UserId_Account = "FK123";
                byte[] imageData = new byte[] { 0x01, 0x02, 0x03 };

                Assert.Throws<ArgumentNullException>(() => new Account(accountId, userName, password, fK_UserId_Account, imageData));
            }

            [Fact]
            public void Test_Constructor_NullPassword()
            {
                int accountId = 1;
                string userName = "TestUser";
                string password = null;
                string fK_UserId_Account = "FK123";
                byte[] imageData = new byte[] { 0x01, 0x02, 0x03 };

                Assert.Throws<ArgumentNullException>(() => new Account(accountId, userName, password, fK_UserId_Account, imageData));
            }

            [Fact]
            public void Test_Constructor_EmptyPassword()
            {
                int accountId = 1;
                string userName = "TestUser";
                string password = "";
                string fK_UserId_Account = "FK123";
                byte[] imageData = new byte[] { 0x01, 0x02, 0x03 };

                Assert.Throws<ArgumentNullException>(() => new Account(accountId, userName, password, fK_UserId_Account, imageData));
            }

            [Fact]
            public void Test_Constructor_NullFK_UserId_Account()
            {
                int accountId = 1;
                string userName = "TestUser";
                string password = "ValidPass123@";
                string fK_UserId_Account = null;
                byte[] imageData = new byte[] { 0x01, 0x02, 0x03 };

                Assert.Throws<ArgumentNullException>(() => new Account(accountId, userName, password, fK_UserId_Account, imageData));
            }

            [Fact]
            public void Test_Constructor_EmptyFK_UserId_Account()
            {
                int accountId = 1;
                string userName = "TestUser";
                string password = "ValidPass123@";
                string fK_UserId_Account = "";
                byte[] imageData = new byte[] { 0x01, 0x02, 0x03 };

                Assert.Throws<ArgumentNullException>(() => new Account(accountId, userName, password, fK_UserId_Account, imageData));
            }

            [Fact] 
            public void Test_Constructor_NullImageData()
            {
                int accountId = 1;
                string userName = "TestUser";
                string password = "ValidPass123@";
                string fK_UserId_Account = "FK123";
                byte[] imageData = null;

                Assert.Throws<ArgumentNullException>(() => new Account(accountId, userName, password, fK_UserId_Account, imageData));
            }

            [Fact]
            public void Test_Constructor_InvalidPassword()
            {
                int accountId = 1;
                string userName = "TestUser";
                string password = "InvalidPass";
                string fK_UserId_Account = "FK123";
                byte[] imageData = new byte[] { 0x01, 0x02, 0x03 };

                Assert.Throws<ArgumentException>(() => new Account(accountId, userName, password, fK_UserId_Account, imageData));
            }

            [Fact]
            public void Test_Constructor_InvalidUserIdLength()
            {
                int accountId = 1;
                string userName = "TestUser";
                string password = "ValidPass123@";
                string fK_UserId_Account = "22-01-0028338";
                byte[] imageData = new byte[] { 0x01, 0x02, 0x03 };

                Assert.Throws<ArgumentNullException>(() => new Account(accountId, userName, password, fK_UserId_Account, imageData));
            }
        }
    }
}

