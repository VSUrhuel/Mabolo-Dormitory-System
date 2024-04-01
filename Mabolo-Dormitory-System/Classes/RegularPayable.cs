using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabolo_Dormitory_System.Classes
{
    public class RegularPayable
    {
        public int RegularPayableId { get; private set; }
        public String Name { get; private set; }
        public float Amount { get; private set; }
       

        public RegularPayable(int regularPayablesId, String payableName, float amount)
        {
            ValidateArg(regularPayablesId, payableName, amount);
            RegularPayableId = regularPayablesId;
            Name = payableName;
            Amount = amount;  
        }

        public void ValidateArg(int regularPayableId, String payableName, float amount)
        {
            if (regularPayableId < 0 || amount < 0)
                throw new ArgumentOutOfRangeException();
            if (payableName == null)
                throw new ArgumentNullException();
            if (payableName == "" || payableName == "  " || payableName.Length > 45)
                throw new ArgumentException();
        }

        public override string ToString()
        {
            return RegularPayableId + ": " + Name + " " + Amount;
        }

    }
}
