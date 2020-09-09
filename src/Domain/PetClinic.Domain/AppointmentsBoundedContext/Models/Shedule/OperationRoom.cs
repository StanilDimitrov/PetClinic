using PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule.Abstraction;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule
{
    public class OperationRoom : BaseRoom
    {
        internal OperationRoom(int roomNumber) :
            base(roomNumber)
        {
        }
    }
}
