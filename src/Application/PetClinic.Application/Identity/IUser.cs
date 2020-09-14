using PetClinic.Domain.AppointmentsBoundedContext.Models.Shedules;

namespace PetClinic.Application.Identity
{
    public interface IUser
    {
        void BecomeDoctor(Doctor doctor);
    }
}
