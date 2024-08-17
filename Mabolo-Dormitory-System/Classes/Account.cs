using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabolo_Dormitory_System.Classes
{
    public class Account
    {
        public int AccountId { get; private set; }
        public String UserName { get; private set; }
        public String Password { get; private set; }
        public String FK_UserId_Account { get; private set; }
        public Byte[] ImageData { get; private set; }

        public Account(int accountId, String userName, String password, String fK_UserId_Account, byte[] imageDate)
        {
            ValidateArg(accountId, userName, password, fK_UserId_Account, imageDate);
            if (ValidationClass.ValidatePassword(password) == false)
            {
                throw new ArgumentException("Invalid password");
            }
            AccountId = accountId;
            UserName = userName;
            Password = password;
            FK_UserId_Account = fK_UserId_Account;
            ImageData = imageDate;
        }

        private void ValidateArg(int accountId, String userName, String password, String fK_UserId_Account, byte[] imageDate)
        {
            if (accountId < 0)
                throw new ArgumentOutOfRangeException();
            if (userName == null || userName.Length == 0 || userName.Length > 100 || userName == " ")
                throw new ArgumentNullException();
            if (password == null || password.Length == 0)
                throw new ArgumentNullException();
            if (fK_UserId_Account == null || fK_UserId_Account.Length == 0 || fK_UserId_Account.Length > 11)
                throw new ArgumentNullException();
            if (imageDate == null)
                throw new ArgumentNullException();
        }

    }
}
