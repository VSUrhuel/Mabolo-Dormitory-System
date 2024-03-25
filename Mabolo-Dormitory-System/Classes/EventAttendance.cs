using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabolo_Dormitory_System.Classes
{
    public class EventAttendance
    {
        public int EventAttendanceId { get; private set; }
        public String AttendanceStatus { get; private set; }
        public String FK_UserId_EventAttendance { get; private set; }
        public int FK_EventId_EventAttendance { get; private set; }
        public EventAttendance(int eventAttendanceId, string attendanceStatus, String fK_UserId_EventAttendance, int fK_EventId_EventAttendance)
        {
            ValidateArg(eventAttendanceId, attendanceStatus, fK_UserId_EventAttendance, fK_EventId_EventAttendance);
            EventAttendanceId = eventAttendanceId;
            AttendanceStatus = attendanceStatus;
            FK_UserId_EventAttendance = fK_UserId_EventAttendance;
            FK_EventId_EventAttendance = fK_EventId_EventAttendance;
        }

        public void ValidateArg(int eventAttendanceId, string attendanceStatus, String fK_UserId_EventAttendance, int fK_EventId_EventAttendance)
        {
            if (eventAttendanceId < 0)
                throw new ArgumentOutOfRangeException();
            if (fK_UserId_EventAttendance == null || attendanceStatus == null)
                throw new ArgumentNullException();
            if (attendanceStatus == "" || attendanceStatus == "  " || attendanceStatus.Length > 45)
                throw new ArgumentException();
            if (fK_EventId_EventAttendance < 0)
                throw new ArgumentOutOfRangeException();
        }
        public override string ToString()
        {
            return FK_UserId_EventAttendance + " in " + FK_EventId_EventAttendance + ": " + AttendanceStatus;
        }
    }
}
