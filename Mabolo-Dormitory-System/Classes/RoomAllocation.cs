using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabolo_Dormitory_System.Classes
{
    public class RoomAllocation
    {
        public int RoomAllocationId { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public int FK_RoomId_RoomAllocation { get; private set; }
        public String FK_UserId_RoomAllocation { get; private set; }

        public RoomAllocation(int roomAllocationId, DateTime startDate, DateTime endDate, int fk_roomId_RoomAllocation, String fk_userId_RoomAllocation)
        {
            ValidateArg(roomAllocationId, startDate, endDate, fk_roomId_RoomAllocation, fk_userId_RoomAllocation);
            RoomAllocationId = roomAllocationId;
            StartDate = startDate;
            EndDate = endDate;
            FK_RoomId_RoomAllocation = fk_roomId_RoomAllocation;
            FK_UserId_RoomAllocation = fk_userId_RoomAllocation;
        }

        public RoomAllocation(int roomAllocationId, DateTime startDate, DateTime endDate, int fk_roomId_RoomAllocation, String fk_userId_RoomAllocation, bool fromDatabase)
        {
            RoomAllocationId = roomAllocationId;
            StartDate = startDate;
            EndDate = endDate;
            FK_RoomId_RoomAllocation = fk_roomId_RoomAllocation;
            FK_UserId_RoomAllocation = fk_userId_RoomAllocation;
        }

        public void ValidateArg(int roomAllocationId, DateTime startDate, DateTime endDate, int fk_roomId_RoomAllocation, String fk_userId_RoomAllocation)
        {
            if (roomAllocationId < 0 || fk_roomId_RoomAllocation < 0)
                throw new ArgumentOutOfRangeException();
            if (startDate < DateTime.Now || endDate < DateTime.Now)
                throw new ArgumentException();
            if (fk_userId_RoomAllocation == null)
                throw new ArgumentNullException();
            if (startDate > endDate)
                throw new ArgumentException();
        }

        public override string ToString()
        {
            return RoomAllocationId + ": " + StartDate.ToString("yyyy-MM-dd") + " " + EndDate.ToString("yyyy-MM-dd");
        }
    }
}
