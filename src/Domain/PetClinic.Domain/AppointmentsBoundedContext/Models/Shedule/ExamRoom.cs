using PetClinic.Domain.Common;
using PetClinic.Domain.Exceptions;
using static PetClinic.Domain.Constants.CommonConstants;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule
{
    public class ExamRoom : Entity<int>
    {
        internal ExamRoom(int roomNumber)
        {
            this.Validate(roomNumber);

            this.RoomNumber = roomNumber;
        }

        public int RoomNumber { get; private set; }

        private void Validate(int roomNumber)
            => Guard.AgainstOutOfRange<InvalidExamRoomException>(
                roomNumber,
                MinRoomNumber,
                MaxRoomNumber,
                nameof(this.RoomNumber));
    }
}
