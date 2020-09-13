using PetClinic.Domain.AppointmentsBoundedContext.Models.Shedules.Abstraction;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedules
{
    public class RecoveryRoom : BaseRoom
    {
        internal RecoveryRoom(int roomNumber) :
           base(roomNumber)
        {
        }
    }
}
