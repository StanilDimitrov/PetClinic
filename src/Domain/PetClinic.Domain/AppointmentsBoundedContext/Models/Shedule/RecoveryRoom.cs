using PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule.Abstraction;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule
{
    public class RecoveryRoom : BaseRoom
    {
        internal RecoveryRoom(int roomNumber) :
           base(roomNumber)
        {
        }
    }
}
