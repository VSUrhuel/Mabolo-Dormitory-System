using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabolo_Dormitory_System.Classes
{
    public class Room
    {
        public int RoomId { get; private set; }
        public int LevelNumber { get; private set; }
        public int MaximumCapacity { get; private set; }
        public int CurrNumOfOccupants { get; private set; }

        public Room(int roomId, int levelNumber, int maximumCapacity, int currNumOfOccupants)
        {
            ValidateArg(roomId, levelNumber, maximumCapacity, currNumOfOccupants);
            RoomId = roomId;
            LevelNumber = levelNumber;
            MaximumCapacity = maximumCapacity;
            CurrNumOfOccupants = currNumOfOccupants;
        }

        public void ValidateArg(int roomId, int levelNumber, int maximumCapacity, int currNumOfOccupants)
        {
            if (roomId < 0 || levelNumber <= 0 || maximumCapacity <= 0 || currNumOfOccupants < 0)
                throw new ArgumentOutOfRangeException();
            if (maximumCapacity < currNumOfOccupants)
                throw new ArgumentException();


        }
        public bool CanIncreaseOccupancy(int n)
        {
            if (CurrNumOfOccupants + n <= MaximumCapacity)
            {
                CurrNumOfOccupants += n;
                return true;
            }
            return false;
        }
        public bool DecreaseOccupants(int n)
        {
            if (CurrNumOfOccupants - n >= 0)
            {
                CurrNumOfOccupants -= n;
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return RoomId + ": " + LevelNumber;
        }
    }
}
