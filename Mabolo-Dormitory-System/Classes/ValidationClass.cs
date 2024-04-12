using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabolo_Dormitory_System.Classes
{
    public class ValidationClass
    {
        public static bool ValidateFieldsNotEmpty(String[] fields)
        {
            foreach (String field in fields)
            {
                if (field == null || field == "" || field == "  ")
                    return false;
            }
            return true;
        }
        public static bool ValidatePassword(String pass)
        {
            bool hasUpperCase = false;
            bool hasNumber = false;
            bool hasSpecial = false;
            foreach (char c in pass)
            {
                if (char.IsUpper(c))
                    hasUpperCase = true;
                if (char.IsNumber(c))
                    hasNumber = true;
                if (!char.IsLetterOrDigit(c))
                    hasSpecial = true;
            }
            if (hasUpperCase && hasNumber && hasSpecial && pass.Length > 7)
                return true;
            return false;
        }
        
        public static bool ValidatePhoneNumber(String phoneNumber)
        {
            try
            {
                long.Parse(phoneNumber.Substring(1, 12));
            }
            catch (Exception)
            {
                return false;
            }
            if (phoneNumber.Length != 13 || phoneNumber[0] != '+')
                return false;
            return true;
        }
        
        public static bool ValidateEmail(String email)
        {
            int atIndex = email.IndexOf('@');
            if (atIndex < 0)
                return false; 

            string domain = email.Substring(atIndex + 1);
            if (!domain.EndsWith(".com") && !domain.EndsWith(".ph"))
                return false; 
            return true;
        }
    }
}
