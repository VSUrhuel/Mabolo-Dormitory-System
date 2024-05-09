using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Mabolo_Dormitory_System.Classes;

namespace Unit_Test
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void Test_Constructor_ValidInput()
        {
            int accountId = 1;
            string userName = "TestUser";
            string password = "ValidPass123@";
            string fK_UserId_Account = "FK123";
            byte[] imageData = new byte[] { 0x01, 0x02, 0x03 };

            Account account = new Account(accountId, userName, password, fK_UserId_Account, imageData);

            Assert.AreEqual(accountId, account.AccountId);
            Assert.AreEqual(userName, account.UserName);
            Assert.AreEqual(password, account.Password);
            Assert.AreEqual(fK_UserId_Account, account.FK_UserId_Account);
            Assert.AreEqual(imageData, account.ImageData);
        }

        [TestMethod]
        public void Test_Constructor_NegativeAccountId()
        {
            // Arrange
            int accountId = -1;
            string userName = "TestUser";
            string password = "ValidPass123";
            string fK_UserId_Account = "FK123";
            byte[] imageData = new byte[] { 0x01, 0x02, 0x03 };

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Account(accountId, userName, password, fK_UserId_Account, imageData));
        }

        [TestMethod]
        public void Test_Constructor_NullUserName()
        {
            int accountId = 1;
            string userName = null;
            string password = "ValidPass123";
            string fK_UserId_Account = "FK123";
            byte[] imageData = new byte[] { 0x01, 0x02, 0x03 };

            Assert.ThrowsException<ArgumentNullException>(() => new Account(accountId, userName, password, fK_UserId_Account, imageData));
        }

        [TestMethod]
        public void Test_Constructor_MinMaxLengths_UserNamePasswordFKUserId()
        {
            int accountId = 1;
            string[] invalidLengths = { "", " ", new string('a', 101), new string('a', 51) }; // Empty, single space, exceeding max length, exceeding FK_UserId_Account max length

            // Loop through different invalid string lengths for username, password, and FK_UserId_Account
            foreach (string invalidLength in invalidLengths)
            {
                // Test username with invalid length
                Assert.ThrowsException<ArgumentNullException>(() => new Account(accountId, invalidLength, "ValidPass123@", "FK123", new byte[] { 0x01, 0x02, 0x03 }));

                // Test password with invalid length
                Assert.ThrowsException<ArgumentNullException>(() => new Account(accountId, "TestUser", invalidLength, "FK123", new byte[] { 0x01, 0x02, 0x03 }));

                // Test FK_UserId_Account with invalid length (assuming max length is 50)
                Assert.ThrowsException<ArgumentNullException>(() => new Account(accountId, "TestUser", "ValidPass123@", invalidLength, new byte[] { 0x01, 0x02, 0x03 }));
            }

        }
    }
}
