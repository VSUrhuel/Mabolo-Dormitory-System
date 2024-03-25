using Mabolo_Dormitory_System.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Mabolo_Dormitory_System.Unit_Test_Classes
{
    public class TestRoomAllocation
    {
        [Fact]
        public void RoomAllocation_Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            int expectedRoomAllocationId = 10001;
            DateTime expectedStartDate = DateTime.Now.AddDays(1); // Start date should be in the future
            DateTime expectedEndDate = expectedStartDate.AddDays(5); // End date should be after start date
            int expectedFKRoomId = 202;
            string expectedFKUserId = "UserABC";

            // Act
            RoomAllocation roomAllocation = new RoomAllocation(expectedRoomAllocationId, expectedStartDate, expectedEndDate, expectedFKRoomId, expectedFKUserId);

            // Assert
            Assert.Equal(expectedRoomAllocationId, roomAllocation.RoomAllocationId);
            Assert.Equal(expectedStartDate, roomAllocation.StartDate);
            Assert.Equal(expectedEndDate, roomAllocation.EndDate);
            Assert.Equal(expectedFKRoomId, roomAllocation.FK_RoomId_RoomAllocation);
            Assert.Equal(expectedFKUserId, roomAllocation.FK_UserId_RoomAllocation);
        }

        // Exception Tests
        [Fact]
        public void RoomAllocation_Constructor_ThrowsArgumentOutOfRangeException_ForInvalidRoomAllocationId()
        {
            // Arrange
            int invalidRoomAllocationId = -2;

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentOutOfRangeException>(() => new RoomAllocation(invalidRoomAllocationId, DateTime.Now.AddDays(1), DateTime.Now.AddDays(5), 202, "UserABC"));
        }

        [Fact]
        public void RoomAllocation_Constructor_ThrowsArgumentException_ForStartDateInThePast()
        {
            // Arrange
            DateTime pastStartDate = DateTime.Now.AddDays(-2);

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentException>(() => new RoomAllocation(1, pastStartDate, DateTime.Now.AddDays(5), 202, "UserABC"));
        }

        [Fact]
        public void RoomAllocation_Constructor_ThrowsArgumentException_ForEndDateBeforeStartDate()
        {
            // Arrange
            DateTime expectedStartDate = DateTime.Now.AddDays(1);
            DateTime endDateBeforeStartDate = expectedStartDate.AddDays(-1);

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentException>(() => new RoomAllocation(1, expectedStartDate, endDateBeforeStartDate, 202, "UserABC"));
        }

        [Fact]
        public void RoomAllocation_Constructor_ThrowsArgumentNullException_ForNullFKUserId()
        {
            // Arrange
            string nullFKUserId = null;

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentNullException>(() => new RoomAllocation(1, DateTime.Now.AddDays(1), DateTime.Now.AddDays(5), 202, nullFKUserId));
        }

        // Edge Case Tests
        
        [Fact]
        public void RoomAllocation_Constructor_HandlesMaximumDateTimeCorrectly()
        {
            // Arrange
            DateTime maximumDateTime = DateTime.MaxValue;

            // Act (EndDate will be set to DateTime.MaxValue)
            RoomAllocation roomAllocation = new RoomAllocation(1, DateTime.Now.AddDays(1), maximumDateTime, 202, "UserABC");

            // Assert
            Assert.Equal(maximumDateTime, roomAllocation.EndDate);
        }

        // ToString Tests
        [Fact]

        public void RoomAllocation_ToString_ReturnsCorrectFormattedString()
        {
            // Arrange
            int expectedRoomAllocationId = 3045;
            DateTime expectedStartDate = DateTime.Now.AddDays(2);
            DateTime expectedEndDate = expectedStartDate.AddDays(3);

            // Act
            RoomAllocation roomAllocation = new RoomAllocation(expectedRoomAllocationId, expectedStartDate, expectedEndDate, 105, "UserXYZ");
            string actualToStringOutput = roomAllocation.ToString();

            // Assert
            string expectedToString = expectedRoomAllocationId + ": " + expectedStartDate.ToString("yyyy-MM-dd") + " " + expectedEndDate.ToString("yyyy-MM-dd");
            Assert.Equal(expectedToString, actualToStringOutput);
        }
    }
}
