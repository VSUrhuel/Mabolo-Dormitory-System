using Mabolo_Dormitory_System.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Mabolo_Dormitory_System.Unit_Test_Classes
{
    public class TestEvent
    {
        [Fact]
        public void Event_Constructor_SetsPropertiesCorrectly()
        {
            int expectedEventId = 1;
            string expectedEventName = "New Year's Party";
            DateTime expectedEventDate = new DateTime(2024, 12, 31);
            DateTime expectedEventTime = new DateTime(2024, 12, 31, 20, 0, 0);
            string expectedLocation = "Main Hall";
            string expectedDescription = "Celebrate the new year together!";
            bool expectedHasPayables = true;
            float expectedAttendanceFineAmount = 100;
            float expectedEventFeeContribution = 500;

            Event eve = new Event(expectedEventId, expectedEventName, expectedEventDate, expectedEventTime, expectedLocation, expectedDescription, expectedHasPayables, expectedAttendanceFineAmount, expectedEventFeeContribution);

            Assert.Equal(expectedEventId, eve.EventId);
            Assert.Equal(expectedEventName, eve.EventName);
            Assert.Equal(expectedEventDate, eve.EventDate);
       
            Assert.Equal(expectedLocation, eve.Location);
            Assert.Equal(expectedDescription, eve.Description);
            Assert.Equal(expectedHasPayables, eve.HasPayables);
            Assert.Equal(expectedAttendanceFineAmount, eve.AttendanceFineAmount);
            Assert.Equal(expectedEventFeeContribution, eve.EventFeeContribution);
        }

        [Fact]
        public void Event_Constructor_ThrowsArgumentNullException_ForNullEventName()
        {
            string nullEventName = null;

            Assert.Throws<ArgumentNullException>(() => new Event(1, nullEventName, DateTime.Now, DateTime.Now, "Location", "Description", true, 0, 0));
        }

        [Fact]
        public void Event_Constructor_ArgumentOutOfRangeException_ForInvalidEventId()
        {
            int invalidEventId = -1;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Event(invalidEventId, "Event Name", DateTime.Now, DateTime.Now, "Location", "Description", true, 0, 0));
        }

        [Fact]
        public void Event_Constructor_ThrowsArgumentOutOfRangeException_ForAttendanceFineAmountLessThanZero()
        {
            float invalidAttendanceFineAmount = -5;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Event(1, "Test Event", DateTime.Now, DateTime.Now, "Location", "Description", true, invalidAttendanceFineAmount, 0));
        }

        [Fact]
        public void Event_Constructor_ThrowsArgumentOutOfRangeException_ForEventFeeContributionLessThanZero()
        {
            float invalidEventFeeContribution = -100;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Event(1, "Test Event", DateTime.Now, DateTime.Now, "Location", "Description", true, 0, invalidEventFeeContribution));
        }
    }
}
