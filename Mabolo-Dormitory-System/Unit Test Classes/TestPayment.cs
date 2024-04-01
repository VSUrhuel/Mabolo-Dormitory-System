using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Mabolo_Dormitory_System.Classes;

namespace Mabolo_Dormitory_System.Unit_Test_Classes
{
    public class TestPayment
    {
        [Fact]
        public void Payment_Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            int expectedPaymentId = 1001;
            DateTime expectedPaymentDate = DateTime.Now;
            float expectedAmount = 150.50f;
            string expectedPaymentStatus = "Paid";
            string expectedFKUserId = "User789";
            string expectedPaymentType = "Regular Payables";
            int expectedFKEventId = 12;
            int expectedFKRegularPayables = 1;

            // Act
            Payment payment = new Payment(expectedPaymentId, expectedPaymentDate, expectedPaymentType,  expectedAmount, expectedPaymentStatus, expectedFKUserId, expectedFKEventId, expectedFKRegularPayables);
            
           
            // Assert
            Assert.Equal(expectedPaymentId, payment.PaymentId);
            Assert.Equal(expectedPaymentDate, payment.PaymentDate);
            Assert.Equal(expectedAmount, payment.Amount);
            Assert.Equal(expectedPaymentStatus, payment.PaymentStatus);
            Assert.Equal(expectedFKUserId, payment.FK_UserId_Payment);
            Assert.Equal(expectedFKEventId, payment.FK_EventId_Payment);
        }

        // Exception Tests
        [Fact]
        public void Payment_Constructor_ThrowsArgumentOutOfRangeException_ForInvalidPaymentId()
        {
            // Arrange
            int invalidPaymentId = -2;

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentOutOfRangeException>(() => new Payment(invalidPaymentId, DateTime.Now, "Regular Payables", 100f, "Paid", "User123", 5, 1));
        }

        [Fact]
        public void Payment_Constructor_ThrowsArgumentOutOfRangeException_ForNegativeAmount()
        {
            // Arrange
            float negativeAmount = -50.0f;

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentOutOfRangeException>(() => new Payment(1, DateTime.Now, "Regular Payables", negativeAmount, "Paid", "User123", 5, 1));
        }

        [Fact]
        public void Payment_Constructor_ThrowsArgumentNullException_ForNullPaymentStatus()
        {
            // Arrange
            string nullPaymentStatus = null;

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentNullException>(() => new Payment(1, DateTime.Now, "Regular Payables", 100f, nullPaymentStatus, "User123", 5, 1));
        }

        [Fact]
        public void Payment_Constructor_ThrowsArgumentNullException_ForNullFKUserId()
        {
            // Arrange
            string nullFKUserId = null;

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentNullException>(() => new Payment(1, DateTime.Now, "Regular Payables", 100f, "Paid", nullFKUserId, 5, 1));
        }

        [Fact]
        public void Payment_Constructor_ThrowsArgumentOutOfRangeException_ForInvalidFKEventId()
        {
            // Arrange
            int invalidFKEventId = -1;

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentOutOfRangeException>(() => new Payment(1, DateTime.Now, "Regular Payables", 100f, "Paid", "User123", invalidFKEventId, 1));
        }

        // String Handling Tests
        [Fact]
        public void Payment_Constructor_ThrowsArgumentException_ForEmptyPaymentStatus()
        {
            // Arrange
            string emptyPaymentStatus = "";

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentException>(() => new Payment(1, DateTime.Now, "Regular Payables", 100f, emptyPaymentStatus, "User123", 5, 1));
        }

        [Fact]
        public void Payment_Constructor_ThrowsArgumentException_ForWhiteSpaceOnlyPaymentStatus()
        {
            // Arrange
            string whitespacePaymentStatus = "  ";

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentException>(() => new Payment(1, DateTime.Now, "Regular Payables", 100f, whitespacePaymentStatus, "User123", 5, 1));
        }

        [Fact]
        public void Payment_Constructor_ThrowsArgumentException_ForExcessivelyLongPaymentStatus()
        {
            // Arrange
            string longPaymentStatus = new string('a', 46); // Assuming a max length of 45 for PaymentStatus

            // Assert for excessively long PaymentStatus
            Assert.Throws<ArgumentException>(() => new Payment(1, DateTime.Now, "Regular Payables", 100f, longPaymentStatus, "User123", 5, 1));
        }

        // ToString Tests
        [Fact]
        public void Payment_ToString_ReturnsCorrectFormattedString()
        {
            // Arrange
            int expectedPaymentId = 1045;
            DateTime expectedPaymentDate = DateTime.Now;
            float expectedAmount = 250.00f;
            string expectedFKUserId = "User143";
            int expectedFKEventId = 20;

            // Act
            Payment payment = new Payment(expectedPaymentId, expectedPaymentDate, "Regular Payables", expectedAmount, "Pending", expectedFKUserId, expectedFKEventId,1);
            string actualToStringOutput = payment.ToString();

            // Assert
            string expectedToString = expectedPaymentId + ": " + expectedPaymentDate.ToString("yyyy-MM-dd HH:mm:ss") + " " + expectedAmount;
            Assert.Equal(expectedToString, actualToStringOutput);
        }

        // Edge Case Tests
        [Fact]
        public void Payment_Constructor_HandlesMinimumDateTimeCorrectly()
        {
            // Arrange
            DateTime minimumDateTime = DateTime.MinValue;

            // Act
            Payment payment = new Payment(1, minimumDateTime, "Regular Payables", 100f, "Paid", "User456", 5, 1);

            // Assert
            Assert.Equal(minimumDateTime, payment.PaymentDate);
        }

        [Fact]
        public void Payment_Constructor_HandlesMaximumDateTimeCorrectly()
        {
            // Arrange
            DateTime maximumDateTime = DateTime.MaxValue;

            // Act
            Payment payment = new Payment(1, maximumDateTime, "Regular Payables", 100f, "Paid", "User789", 10, 1);

            // Assert
            Assert.Equal(maximumDateTime, payment.PaymentDate);
        }

        [Fact]
        public void Payment_Constructor_HandlesMaximumAmountCorrectly()
        {
            // Arrange
            float maximumAmount = float.MaxValue;

            // Act
            Payment payment = new Payment(1, DateTime.Now, "Regular Payables", maximumAmount, "Paid", "User123", 5, 1);

            // Assert
            Assert.Equal(maximumAmount, payment.Amount);
        }
    }
    }
