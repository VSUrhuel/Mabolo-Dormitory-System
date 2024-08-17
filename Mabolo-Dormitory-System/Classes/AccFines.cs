using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabolo_Dormitory_System.Classes
{
    public class AccFines
    {
        public int AccFinesId {  get; private set; }
        public string Month {  get; private set; }
        public float Amount { get; private set; }   
        public string FK_AccFinesId_UserId {  get; private set; }

        public AccFines(int accFinesId, string month, float amount, string fK_AccFinesId_UserId)
        {
            if(amount < 0)
                amount = 0;
            AccFinesId = accFinesId;
            Month = month;
            Amount = amount;
            FK_AccFinesId_UserId = fK_AccFinesId_UserId;
        }
    }
}
