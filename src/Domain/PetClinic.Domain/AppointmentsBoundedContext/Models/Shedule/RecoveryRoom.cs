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

            this.RecoveryRoomNumber = roomNumber;
        }

        public int RecoveryRoomNumber { get; private set; }

        private void Validate(int roomNumber)
          => Guard.AgainstOutOfRange<InvalidRecoveryRoomException>(
              roomNumber,
              MinRoomNumber,
              MaxRoomNumber,
              nameof(this.RecoveryRoomNumber));
    }
}
