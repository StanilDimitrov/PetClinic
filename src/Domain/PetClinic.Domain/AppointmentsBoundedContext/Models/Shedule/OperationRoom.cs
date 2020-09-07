using PetClinic.Domain.Common;
using PetClinic.Domain.Exceptions;
using static PetClinic.Domain.Constants.CommonConstants;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule
{
    public class OperationRoom : Entity<int>
    {
        internal OperationRoom(int roomNumber)
        {
            this.Validate(roomNumber);

            this.OperationRoomNumber = roomNumber;
        }

        public int OperationRoomNumber { get; private set; }

        private void Validate(int roomNumber)
           => Guard.AgainstOutOfRange<InvalidOperationRoomException>(
               roomNumber,
               MinRoomNumber,
               MaxRoomNumber,
               nameof(this.OperationRoomNumber));
    }
}
