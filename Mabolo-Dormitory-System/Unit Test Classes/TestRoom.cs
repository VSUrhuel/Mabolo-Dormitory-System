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
            int expectedRoomId = 101;
            int expectedLevelNumber = 2;
            int expectedMaximumCapacity = 50;
            int expectedCurrNumOfOccupants = 0;
            
            Room room = new Room(expectedRoomId, expectedLevelNumber, expectedMaximumCapacity, expectedCurrNumOfOccupants);

            Assert.Equal(expectedRoomId, room.RoomId);
            Assert.Equal(expectedLevelNumber, room.LevelNumber);
            Assert.Equal(expectedMaximumCapacity, room.MaximumCapacity);
            Assert.Equal(expectedCurrNumOfOccupants, room.CurrNumOfOccupants);
        }

        [Fact]
        public void Room_Constructor_ThrowsArgumentOutOfRangeException_ForInvalidRoomId()
        {
            int invalidRoomId = -1;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Room(invalidRoomId, 2, 50, 0));
        }

        [Fact]
        public void Room_Constructor_ThrowsArgumentOutOfRangeException_ForInvalidLevelNumber()
        {
            int invalidLevelNumber = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Room(1, invalidLevelNumber, 50, 0));
        }

        [Fact]
        public void Room_Constructor_ThrowsArgumentOutOfRangeException_ForInvalidMaximumCapacity()
        {
            int invalidMaximumCapacity = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Room(1, 2, invalidMaximumCapacity, 0));
        }

        [Fact]
        public void Room_Constructor_ThrowsArgumentOutOfRangeException_ForNegativeCurrNumOfOccupants()
        {
            int negativeCurrNumOfOccupants = -5;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Room(1, 2, 50, negativeCurrNumOfOccupants));
        }

        [Fact]
        public void Room_Constructor_ThrowsArgumentException_ForCurrNumOfOccupantsExceedingCapacity()
        {
            int maximumCapacity = 20;
            int exceedingCurrNumOfOccupants = 25;

            Assert.Throws<ArgumentException>(() => new Room(1, 2, maximumCapacity, exceedingCurrNumOfOccupants));
        }

        [Fact]
        public void Room_Constructor_HandlesMaximumRoomIdCorrectly()
        {
            int maximumRoomId = int.MaxValue;

            Room room = new Room(maximumRoomId, 2, 50, 0);

            Assert.Equal(maximumRoomId, room.RoomId);
        }

        [Fact]
        public void Room_Constructor_HandlesMinimumLevelNumberCorrectly()
        {
            int minimumLevelNumber = 1;

            Room room = new Room(1, minimumLevelNumber, 50, 0);

            Assert.Equal(minimumLevelNumber, room.LevelNumber);
        }

        [Fact]
        public void Room_Constructor_HandlesMaximumLevelNumberCorrectly()
        {
            int maximumLevelNumber = int.MaxValue; 

            Room room = new Room(1, maximumLevelNumber, 50, 0);

            Assert.Equal(maximumLevelNumber, room.LevelNumber);
        }

        [Fact]
        public void Room_Constructor_HandlesMaximumCapacityCorrectly()
        {
            int maximumCapacity = int.MaxValue; 

            Room room = new Room(1, 2, maximumCapacity, 0);

            Assert.Equal(maximumCapacity, room.MaximumCapacity);
        }

        [Fact]
        public void Room_ToString_ReturnsCorrectFormattedString()
        {
            int expectedRoomId = 205;
            int expectedLevelNumber = 3;

            Room room = new Room(expectedRoomId, expectedLevelNumber, 100, 25);
            string actualToStringOutput = room.ToString();

            string expectedToString = expectedRoomId + ": " + expectedLevelNumber;
            Assert.Equal(expectedToString, actualToStringOutput);
        }

        [Fact]
        public void Room_CanIncreaseOccupancy_ForAvailableSpace()
        {
            int initialCurrNumOfOccupants = 10;
            int maximumCapacity = 50;
            int additionalOccupants = 15;

            Room room = new Room(1, 2, maximumCapacity, initialCurrNumOfOccupants);

            bool occupancyIncreased = room.CanIncreaseOccupancy(additionalOccupants);

            Assert.True(occupancyIncreased);
            Assert.Equal(initialCurrNumOfOccupants + additionalOccupants, room.CurrNumOfOccupants);
        }

        [Fact]
        public void Room_CanIncreaseOccupancy_ForFullCapacity()
        {
            int initialCurrNumOfOccupants = 50;
            int maximumCapacity = 50;
            int additionalOccupants = 5;

            Room room = new Room(1, 2, maximumCapacity, initialCurrNumOfOccupants);

            bool occupancyIncreased = room.CanIncreaseOccupancy(additionalOccupants);

            Assert.False(occupancyIncreased);
            Assert.Equal(initialCurrNumOfOccupants, room.CurrNumOfOccupants);
        }

        [Fact]
        public void Room_CanIncreaseOccupancy_ForExceedingCapacity()
        {
            int initialCurrNumOfOccupants = 30;
            int maximumCapacity = 50;
            int exceedingAdditionalOccupants = 25; 

            Room room = new Room(1, 2, maximumCapacity, initialCurrNumOfOccupants);

            bool occupancyIncreased = room.CanIncreaseOccupancy(exceedingAdditionalOccupants);

            Assert.False(occupancyIncreased);
            Assert.Equal(initialCurrNumOfOccupants, room.CurrNumOfOccupants);
        }
    }
}
