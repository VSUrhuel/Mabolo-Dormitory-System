using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabolo_Dormitory_System.Classes
{
    public class Book
    {
        public String bookID { get; set; }
        public String title { get; set; }
        public String description { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }

        Book(String bookdID, ...)
        {
            bookID = bookdID;
        }

        public String bokInfo()
        {
            return "The book info is " + title + " description " + description;
        }
    }
}
