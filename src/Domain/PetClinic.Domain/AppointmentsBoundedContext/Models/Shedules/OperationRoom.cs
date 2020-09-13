using PetClinic.Domain.AppointmentsBoundedContext.Models.Shedules.Abstraction;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedules
{
    public class OperationRoom : BaseRoom
    {
        internal OperationRoom(int roomNumber) :
            base(roomNumber)
        {
        }
    }
}
