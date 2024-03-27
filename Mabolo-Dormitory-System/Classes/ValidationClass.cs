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
        public static bool ValidateDate(DateTime date)
        {
            try
            {
                DateTime.Parse(date.ToString());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool ValidateDateValid(DateTime date)
        {
            if (date > DateTime.Now)
                return false;
            return true;
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
            if (!domain.EndsWith(".com"))
                return false; 
            return true;
        }
    }
}
