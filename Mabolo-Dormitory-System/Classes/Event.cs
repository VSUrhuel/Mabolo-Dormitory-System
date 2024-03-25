using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabolo_Dormitory_System.Classes
{
    public class Event
    {
        public int EventId { get; private set; }
        public String EventName { get; private set; }
        public DateTime EventDate { get; private set; }
        public DateTime EventTime { get; private set; }
        public String Location { get; private set; }
        public String Description { get; private set; }
        public Boolean HasPayables { get; private set; }
        public float AttendanceFineAmount { get; private set; }
        public float EventFeeContribution { get; private set; }

        public Event(int eventId, string eventName, DateTime eventDate, DateTime eventTime, string location, string description, bool hasPayables, float attendanceFineAmount, float eventFeeContribution)
        {
            ValidateArg(eventId, eventName, eventDate, eventTime, location, description, hasPayables, attendanceFineAmount, eventFeeContribution);
            

            EventId = eventId;
            EventName = eventName;
            EventDate = eventDate;
            EventTime = eventTime;
            Location = location;
            Description = description;
            HasPayables = hasPayables;
            AttendanceFineAmount = attendanceFineAmount;
            EventFeeContribution = eventFeeContribution;
        }

        private void ValidateArg(int eventId, string eventName, DateTime eventDate, DateTime eventTime, String location, String description, bool hasPayables, float attendanceFineAmount, float eventFeeContribution)
        {
            if (eventId < 0 || attendanceFineAmount < 0 || eventFeeContribution < 0)
                throw new ArgumentOutOfRangeException();

            if (eventName == null)
                throw new ArgumentNullException();

            if (eventDate < DateTime.Now || eventTime < DateTime.Now)
                throw new ArgumentException();
            if (eventTime.Date < eventDate.Date)
                throw new ArgumentException();
        }

        public override string ToString()
        {
            return EventId + ": " + EventName;
        }

    }
}
