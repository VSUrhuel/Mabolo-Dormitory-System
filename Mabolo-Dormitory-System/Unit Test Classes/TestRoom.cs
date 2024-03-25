using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mabolo_Dormitory_System.Classes;
using Xunit;

namespace Mabolo_Dormitory_System.Unit_Test_Classes
{
    public class TestRoom
    {
        [Fact]
        public void Room_Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            int expectedRoomId = 101;
            int expectedLevelNumber = 2;
            int expectedMaximumCapacity = 50;
            int expectedCurrNumOfOccupants = 0;

            // Act
            Room room = new Room(expectedRoomId, expectedLevelNumber, expectedMaximumCapacity, expectedCurrNumOfOccupants);

            // Assert
            Assert.Equal(expectedRoomId, room.RoomId);
            Assert.Equal(expectedLevelNumber, room.LevelNumber);
            Assert.Equal(expectedMaximumCapacity, room.MaximumCapacity);
            Assert.Equal(expectedCurrNumOfOccupants, room.CurrNumOfOccupants);
        }

        // Exception Tests
        [Fact]
        public void Room_Constructor_ThrowsArgumentOutOfRangeException_ForInvalidRoomId()
        {
            // Arrange
            int invalidRoomId = -1;

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentOutOfRangeException>(() => new Room(invalidRoomId, 2, 50, 0));
        }

        [Fact]
        public void Room_Constructor_ThrowsArgumentOutOfRangeException_ForInvalidLevelNumber()
        {
            // Arrange
            int invalidLevelNumber = 0;

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentOutOfRangeException>(() => new Room(1, invalidLevelNumber, 50, 0));
        }

        [Fact]
        public void Room_Constructor_ThrowsArgumentOutOfRangeException_ForInvalidMaximumCapacity()
        {
            // Arrange
            int invalidMaximumCapacity = 0;

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentOutOfRangeException>(() => new Room(1, 2, invalidMaximumCapacity, 0));
        }

        [Fact]
        public void Room_Constructor_ThrowsArgumentOutOfRangeException_ForNegativeCurrNumOfOccupants()
        {
            // Arrange
            int negativeCurrNumOfOccupants = -5;

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentOutOfRangeException>(() => new Room(1, 2, 50, negativeCurrNumOfOccupants));
        }

        [Fact]
        public void Room_Constructor_ThrowsArgumentException_ForCurrNumOfOccupantsExceedingCapacity()
        {
            // Arrange
            int maximumCapacity = 20;
            int exceedingCurrNumOfOccupants = 25;

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentException>(() => new Room(1, 2, maximumCapacity, exceedingCurrNumOfOccupants));
        }

         //Edge Test Cases

        [Fact]
        public void Room_Constructor_HandlesMaximumRoomIdCorrectly()
        {
            // Arrange
            int maximumRoomId = int.MaxValue;

            // Act
            Room room = new Room(maximumRoomId, 2, 50, 0);

            // Assert
            Assert.Equal(maximumRoomId, room.RoomId);
        }

        [Fact]
        public void Room_Constructor_HandlesMinimumLevelNumberCorrectly()
        {
            // Arrange
            int minimumLevelNumber = 1;

            // Act
            Room room = new Room(1, minimumLevelNumber, 50, 0);

            // Assert
            Assert.Equal(minimumLevelNumber, room.LevelNumber);
        }

        [Fact]
        public void Room_Constructor_HandlesMaximumLevelNumberCorrectly()
        {
            // Arrange
            int maximumLevelNumber = int.MaxValue; // Assuming LevelNumber has no specific upper bound

            // Act
            Room room = new Room(1, maximumLevelNumber, 50, 0);

            // Assert
            Assert.Equal(maximumLevelNumber, room.LevelNumber);
        }

        [Fact]
        public void Room_Constructor_HandlesMaximumCapacityCorrectly()
        {
            // Arrange
            int maximumCapacity = int.MaxValue; // Assuming MaximumCapacity has no specific upper bound

            // Act
            Room room = new Room(1, 2, maximumCapacity, 0);

            // Assert
            Assert.Equal(maximumCapacity, room.MaximumCapacity);
        }

        // ToString Tests
        [Fact]
        public void Room_ToString_ReturnsCorrectFormattedString()
        {
            // Arrange
            int expectedRoomId = 205;
            int expectedLevelNumber = 3;

            // Act
            Room room = new Room(expectedRoomId, expectedLevelNumber, 100, 25);
            string actualToStringOutput = room.ToString();

            // Assert
            string expectedToString = expectedRoomId + ": " + expectedLevelNumber;
            Assert.Equal(expectedToString, actualToStringOutput);
        }

        // Occupancy Tests
        [Fact]
        public void Room_CanIncreaseOccupancy_ForAvailableSpace()
        {
            // Arrange
            int initialCurrNumOfOccupants = 10;
            int maximumCapacity = 50;
            int additionalOccupants = 15;

            Room room = new Room(1, 2, maximumCapacity, initialCurrNumOfOccupants);

            // Act
            bool occupancyIncreased = room.CanIncreaseOccupancy(additionalOccupants);

            // Assert
            Assert.True(occupancyIncreased);
            Assert.Equal(initialCurrNumOfOccupants + additionalOccupants, room.CurrNumOfOccupants);
        }

        [Fact]
        public void Room_CanIncreaseOccupancy_ForFullCapacity()
        {
            // Arrange
            int initialCurrNumOfOccupants = 50; // Full capacity
            int maximumCapacity = 50;
            int additionalOccupants = 5;

            Room room = new Room(1, 2, maximumCapacity, initialCurrNumOfOccupants);

            // Act
            bool occupancyIncreased = room.CanIncreaseOccupancy(additionalOccupants);

            // Assert
            Assert.False(occupancyIncreased);
            Assert.Equal(initialCurrNumOfOccupants, room.CurrNumOfOccupants);
        }

        [Fact]
        public void Room_CanIncreaseOccupancy_ForExceedingCapacity()
        {
            // Arrange
            int initialCurrNumOfOccupants = 30;
            int maximumCapacity = 50;
            int exceedingAdditionalOccupants = 25; // Exceeds capacity

            Room room = new Room(1, 2, maximumCapacity, initialCurrNumOfOccupants);

            // Act
            bool occupancyIncreased = room.CanIncreaseOccupancy(exceedingAdditionalOccupants);

            // Assert
            Assert.False(occupancyIncreased);
            Assert.Equal(initialCurrNumOfOccupants, room.CurrNumOfOccupants);
        }

    }
}
