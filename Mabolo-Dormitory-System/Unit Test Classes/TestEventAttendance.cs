using Mabolo_Dormitory_System.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Mabolo_Dormitory_System.Unit_Test_Classes
{
    public class TestEventAttendance
    {
        [Fact]
        public void EventAttendance_Constructor_SetsPropertiesCorrectly()
        {
            int expectedEventAttendanceId = 101;
            string expectedAttendanceStatus = "Present";
            string expectedFKUserId = "User123";
            int expectedFKEventId = 5;

            EventAttendance eventAttendance = new EventAttendance(expectedEventAttendanceId, expectedAttendanceStatus, expectedFKUserId, expectedFKEventId);

            Assert.Equal(expectedEventAttendanceId, eventAttendance.EventAttendanceId);
            Assert.Equal(expectedAttendanceStatus, eventAttendance.AttendanceStatus);
            Assert.Equal(expectedFKUserId, eventAttendance.FK_UserId_EventAttendance);
            Assert.Equal(expectedFKEventId, eventAttendance.FK_EventId_EventAttendance);
        }

        [Fact]
        public void EventAttendance_Constructor_ThrowsArgumentOutOfRangeException_ForInvalidEventAttendanceId()
        {
            int invalidEventAttendanceId = -1;

            Assert.Throws<ArgumentOutOfRangeException>(() => new EventAttendance(invalidEventAttendanceId, "Present", "User123", 5));
        }

        [Fact]
        public void EventAttendance_Constructor_ThrowsArgumentNullException_ForNullAttendanceStatus()
        {
            string nullAttendanceStatus = null;

            Assert.Throws<ArgumentNullException>(() => new EventAttendance(1, nullAttendanceStatus, "User123", 5));
        }

        [Fact]
        public void EventAttendance_Constructor_ThrowsArgumentNullException_ForNullFKUserId()
        {
            string nullFKUserId = null;

            Assert.Throws<ArgumentNullException>(() => new EventAttendance(1, "Present", nullFKUserId, 5));
        }

        [Fact]
        public void EventAttendance_Constructor_ThrowsArgumentOutOfRangeException_ForInvalidFKEventId()
        {
            int invalidFKEventId = -2;

            Assert.Throws<ArgumentOutOfRangeException>(() => new EventAttendance(1, "Present", "User456", invalidFKEventId));
        }

        [Fact]
        public void EventAttendance_Constructor_ThrowsArgumentException_ForEmptyAttendanceStatus()
        {
            string emptyAttendanceStatus = "";

            Assert.Throws<ArgumentException>(() => new EventAttendance(1, emptyAttendanceStatus, "User123", 5));
        }

        [Fact]
        public void EventAttendance_Constructor_ThrowsArgumentException_ForWhiteSpaceOnlyAttendanceStatus()
        {
            string whitespaceAttendanceStatus = "  ";

            Assert.Throws<ArgumentException>(() => new EventAttendance(1, whitespaceAttendanceStatus, "User123", 5));
        }

        [Fact]
        public void EventAttendance_Constructor_ThrowsArgumentException_ForExcessivelyLongAttendanceStatus()
        {
            string longAttendanceStatus = new string('a', 46);

            Assert.Throws<ArgumentException>(() => new EventAttendance(1, longAttendanceStatus, "User123", 5));
        }

        [Fact]
        public void EventAttendance_ToString_ReturnsCorrectFormattedString()
        {
            string expectedFKUserId = "User123";
            int expectedFKEventId = 5;
            string expectedAttendanceStatus = "Present";

            EventAttendance eventAttendance = new EventAttendance(1, expectedAttendanceStatus, expectedFKUserId, expectedFKEventId);
            string actualToStringOutput = eventAttendance.ToString();
            string expectedToString = expectedFKUserId + " in " + expectedFKEventId + ": " + expectedAttendanceStatus;
            Assert.Equal(expectedToString, actualToStringOutput);
        }
    }
}
