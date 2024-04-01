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
        public String PaymentType { get; private set; }
        public float Amount { get; private set; }
        public string PaymentStatus { get; private set; }
        public String FK_UserId_Payment { get; private set; }
        public int FK_EventId_Payment { get; private set; }
        public int FK_RegularPayablesId_Payment { get; private set; }

        public Payment(int paymentId, DateTime paymentDate, String paymentType, float amount, String paymentStatus, string fK_UserId_Payment, int fK_EventId_Payment, int fK_RegulaarPayablesId_Payment)
        {
            ValidateArg(paymentId, paymentDate, amount, paymentStatus, fK_UserId_Payment, fK_EventId_Payment);
            PaymentId = paymentId;
            PaymentDate = paymentDate;
            PaymentType = paymentType;
            Amount = amount;
            PaymentStatus = paymentStatus;
            FK_UserId_Payment = fK_UserId_Payment;
            FK_EventId_Payment = fK_EventId_Payment;
            FK_RegularPayablesId_Payment = FK_RegularPayablesId_Payment;
        }   

        public void ValidateArg(int paymentId, DateTime paymentDate, float amount, string paymentStatus, string fK_UserId_Payment, int fK_EventId_Payment)
        {
            if (paymentId < 0 || amount < 0 || fK_EventId_Payment < 0)
                throw new ArgumentOutOfRangeException();
            if (fK_UserId_Payment == null || paymentStatus == null)
                throw new ArgumentNullException();
            if (paymentStatus == "" || paymentStatus == "  " || paymentStatus.Length > 45)
                throw new ArgumentException();
            
        }

        public override string ToString()
        {
            return PaymentId + ": " + PaymentDate.ToString("yyyy-MM-dd HH:mm:ss") + " " + Amount;
        }
    }
}
