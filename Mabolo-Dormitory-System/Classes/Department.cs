using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabolo_Dormitory_System.Classes
{
    public class Department
    {
        public int DepartmentId { get; private set; }
        public String DepartmentName { get; private set; }
        public String CollegeName { get; private set; }

        public Department(int departmentId, String departmentName, String collegeName)
        {
            ValidateArg(departmentId, departmentName, collegeName);
            DepartmentId = departmentId;
            DepartmentName = departmentName;
            CollegeName = collegeName;
        }
        
        public void ValidateArg(int departmentId, String departmentName, String collegeName)
        {
            if (departmentId < 0)
                throw new ArgumentOutOfRangeException();
            if (departmentName == null || collegeName == null)
                throw new ArgumentNullException();
            if (departmentName == "" || departmentName == "  " || departmentName.Length > 100)
                throw new ArgumentException();
            if (collegeName == "" || collegeName == "  " || collegeName.Length > 100)
                throw new ArgumentException();
        }

        public override string ToString()
        {
            return DepartmentId + ": " + DepartmentName;
        }
    }
}
