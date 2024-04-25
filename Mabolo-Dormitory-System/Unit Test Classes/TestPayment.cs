using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Mabolo_Dormitory_System.Classes;

namespace Mabolo_Dormitory_System.Unit_Test_Classes
{
    public class PaymentTests
    {
        [Fact]
        public void Constructor_SetsPropertiesCorrectly()
        {
            var paymentId = 1;
            var paymentDate = DateTime.Parse("2024-04-20");
            var amount = 25.5f;
            var remarks = "Rent Payment";
            var fkUserIdPayment = "user_abc";

                
            var payment = new Payment(paymentId, paymentDate, amount, remarks, fkUserIdPayment);

            Assert.Equal(paymentId, payment.PaymentId);
            Assert.Equal(paymentDate, payment.PaymentDate);
            Assert.Equal(amount, payment.Amount);
            Assert.Equal(remarks, payment.Remarks);
            Assert.Equal(fkUserIdPayment, payment.FK_UserId_Payment);
        }

        [Fact]
        public void Constructor_Invalid_PaymentId()
        {
            var paymentId = -1;
            var paymentDate = DateTime.Parse("2024-04-20");
            var amount = 25.5f;
            var remarks = "Rent Payment";
            var fkUserIdPayment = "user_abc";

            Assert.Throws<ArgumentOutOfRangeException>(() => new Payment(paymentId, paymentDate, amount, remarks, fkUserIdPayment));
        }

        [Fact]
        public void Constructor_Invalid_Amount()
        {
            var paymentId = 1;
            var paymentDate = DateTime.Parse("2024-04-20");
            var amount = -25.5f;
            var remarks = "Rent Payment";
            var fkUserIdPayment = "user_abc";

            Assert.Throws<ArgumentException>(() => new Payment(paymentId, paymentDate, amount, remarks, fkUserIdPayment));
        }

        [Fact]
        public void Constructor_Null_Remarks()
        {
            var paymentId = 1;
            var paymentDate = DateTime.Parse("2024-04-20");
            var amount = 25.5f;
            string remarks = null;
            var fkUserIdPayment = "user_abc";

            Assert.Throws<ArgumentNullException>(() => new Payment(paymentId, paymentDate, amount, remarks, fkUserIdPayment));
        }

        [Fact]
        public void ToString_ReturnsFormattedString()
        {
            var paymentDate = DateTime.Parse("2024-04-20");
            var payment = new Payment(1, paymentDate, 25.5f, "Rent Payment", "user_abc");

            var expectedString = $"1: 2024-04-20 25.5";

            Assert.Equal(expectedString, payment.ToString());
        }

    }
}
