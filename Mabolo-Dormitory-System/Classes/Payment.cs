using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabolo_Dormitory_System.Classes
{
    public class Payment
    {
        public int PaymentId { get; private set; }
        public DateTime PaymentDate { get; private set; }
        public float Amount { get; private set; }
        public String Remarks { get; private set; }
        public String FK_UserId_Payment { get; private set; }

        public Payment(int paymentId, DateTime paymentDate, float amount, string remarks, String fK_UserId_Payment)
        {
            ValidateArg(paymentId, paymentDate, amount, remarks, fK_UserId_Payment);
            PaymentId = paymentId;
            PaymentDate = paymentDate;
            Amount = amount;
            Remarks = remarks;
            FK_UserId_Payment = fK_UserId_Payment;
        }
        
        private void ValidateArg(int paymentId, DateTime paymentDate, float amount, string remarks, String fK_UserId_Payment)
        {
            if (paymentId < 0)
                throw new ArgumentOutOfRangeException();
           
            if (remarks == null)
                throw new ArgumentNullException();
            if (amount < 0)
                throw new ArgumentException();
        }

        public override string ToString()
        {
            return PaymentId + ": " + PaymentDate.ToString("yyyy-MM-dd") + " " + Amount;
        }
    }
}
