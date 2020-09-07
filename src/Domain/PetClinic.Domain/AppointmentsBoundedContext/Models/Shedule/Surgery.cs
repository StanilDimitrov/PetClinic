using PetClinic.Domain.Common;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule
{
    public class Surgery : Entity<int>
    {
        internal Surgery(
            Doctor doctor,
            OperationRoom operationRoom,
            RecoveryRoom recoveryRoom)
        {
            this.Doctor = doctor;
            this.OperationRoom = operationRoom;
            this.RecoveryRoom = recoveryRoom;
        }
        public Doctor Doctor { get; private set; }

        public OperationRoom OperationRoom { get; set; }

        public RecoveryRoom RecoveryRoom { get; set; }
    }
}
