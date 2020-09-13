using PetClinic.Domain.Common;
using PetClinic.Domain.Exceptions;
using static PetClinic.Domain.Constants.CommonConstants;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedules.Abstraction
{
    public abstract class BaseRoom : Entity<int>
    {
        internal BaseRoom(int roomNumber)
        {
            this.Validate(roomNumber);

            this.RoomNumber = roomNumber;
        }

        public int RoomNumber { get; private set; }

        private void Validate(int roomNumber)
            => Guard.AgainstOutOfRange<InvalidBasicRoomException>(
                roomNumber,
                MinRoomNumber,
                MaxRoomNumber,
                nameof(this.RoomNumber));
    }
}
