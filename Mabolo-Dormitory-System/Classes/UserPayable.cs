using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabolo_Dormitory_System.Classes
{
    public class UserPayable
    {
        public int UserPayableId { get; private set; }
        public float RemainingBalance { get; private set; }
        public String FK_UserId_UserPayable { get; private set; }
        
        public UserPayable(int userPayableId, float remainingBalance, String fK_UserId_UserPayable)
        {
            ValidateArg(userPayableId, remainingBalance, fK_UserId_UserPayable);
            UserPayableId = userPayableId;
            if(remainingBalance < 0)
                RemainingBalance = 0;
            else
                RemainingBalance = remainingBalance;
            FK_UserId_UserPayable = fK_UserId_UserPayable;
        }

        private void ValidateArg(int userPayableId, float remainingBalance, String fK_UserId_UserPayable)
        {
            if (userPayableId < 0)
                throw new ArgumentOutOfRangeException();
            
        }
        public override string ToString()
        {
            return UserPayableId + ": " + RemainingBalance;
        }
    }
}
