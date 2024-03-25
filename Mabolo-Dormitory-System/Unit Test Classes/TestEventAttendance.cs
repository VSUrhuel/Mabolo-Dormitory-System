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
            // Arrange
            int expectedEventAttendanceId = 101;
            string expectedAttendanceStatus = "Present";
            string expectedFKUserId = "User123";
            int expectedFKEventId = 5;

            // Act
            EventAttendance eventAttendance = new EventAttendance(expectedEventAttendanceId, expectedAttendanceStatus, expectedFKUserId, expectedFKEventId);

            // Assert
            Assert.Equal(expectedEventAttendanceId, eventAttendance.EventAttendanceId);
            Assert.Equal(expectedAttendanceStatus, eventAttendance.AttendanceStatus);
            Assert.Equal(expectedFKUserId, eventAttendance.FK_UserId_EventAttendance);
            Assert.Equal(expectedFKEventId, eventAttendance.FK_EventId_EventAttendance);
        }

        // Exception Tests
        [Fact]
        public void EventAttendance_Constructor_ThrowsArgumentOutOfRangeException_ForInvalidEventAttendanceId()
        {
            // Arrange
            int invalidEventAttendanceId = -1;

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentOutOfRangeException>(() => new EventAttendance(invalidEventAttendanceId, "Present", "User123", 5));
        }

        [Fact]
        public void EventAttendance_Constructor_ThrowsArgumentNullException_ForNullAttendanceStatus()
        {
            // Arrange
            string nullAttendanceStatus = null;

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentNullException>(() => new EventAttendance(1, nullAttendanceStatus, "User123", 5));
        }

        [Fact]
        public void EventAttendance_Constructor_ThrowsArgumentNullException_ForNullFKUserId()
        {
            // Arrange
            string nullFKUserId = null;

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentNullException>(() => new EventAttendance(1, "Present", nullFKUserId, 5));
        }

        [Fact]
        public void EventAttendance_Constructor_ThrowsArgumentOutOfRangeException_ForInvalidFKEventId()
        {
            // Arrange
            int invalidFKEventId = -2;

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentOutOfRangeException>(() => new EventAttendance(1, "Present", "User456", invalidFKEventId));
        }

        // String Handling Tests
        [Fact]
        public void EventAttendance_Constructor_ThrowsArgumentException_ForEmptyAttendanceStatus()
        {
            // Arrange
            string emptyAttendanceStatus = "";

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentException>(() => new EventAttendance(1, emptyAttendanceStatus, "User123", 5));
        }

        [Fact]
        public void EventAttendance_Constructor_ThrowsArgumentException_ForWhiteSpaceOnlyAttendanceStatus()
        {
            // Arrange
            string whitespaceAttendanceStatus = "  ";

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentException>(() => new EventAttendance(1, whitespaceAttendanceStatus, "User123", 5));
        }

        [Fact]
        public void EventAttendance_Constructor_ThrowsArgumentException_ForExcessivelyLongAttendanceStatus()
        {
            // Arrange
            string longAttendanceStatus = new string('a', 46); //A max length of 45 for AttendanceStatus

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentException>(() => new EventAttendance(1, longAttendanceStatus, "User123", 5));
        }

        // ToString Tests
        [Fact]
        public void EventAttendance_ToString_ReturnsCorrectFormattedString()
        {
            // Arrange
            string expectedFKUserId = "User123";
            int expectedFKEventId = 5;
            string expectedAttendanceStatus = "Present";

            // Act
            EventAttendance eventAttendance = new EventAttendance(1, expectedAttendanceStatus, expectedFKUserId, expectedFKEventId);
            string actualToStringOutput = eventAttendance.ToString();

            // Assert
            string expectedToString = expectedFKUserId + " in " + expectedFKEventId + ": " + expectedAttendanceStatus;
            Assert.Equal(expectedToString, actualToStringOutput);
        }
    }
}
