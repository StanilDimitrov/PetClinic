using PetClinic.Domain.Common;
using PetClinic.Domain.Exceptions;
using static PetClinic.Domain.Constants.CommonConstants;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule
{
    public class RecoveryRoom : Entity<int>
    {
        internal RecoveryRoom(int roomNumber)
        {
            this.Validate(roomNumber);

            this.RoomNumber = roomNumber;
        }

        public int RoomNumber { get; private set; }

        private void Validate(int roomNumber)
          => Guard.AgainstOutOfRange<InvalidRecoveryRoomException>(
              roomNumber,
              MinRoomNumber,
              MaxRoomNumber,
              nameof(this.RoomNumber));
    }
}
