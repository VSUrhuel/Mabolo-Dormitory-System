using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mabolo_Dormitory_System.Classes;
using Mabolo_Dormitory_System.Unit_Test_Classes;
using Org.BouncyCastle.Asn1.Crmf;
namespace Mabolo_Dormitory_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DatabaseManager db = new DatabaseManager();
            //db.RecordAttendance("20-05-00022", 1);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignIn());
        }
    }
}
