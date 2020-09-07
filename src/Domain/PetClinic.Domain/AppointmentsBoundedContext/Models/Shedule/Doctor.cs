using PetClinic.Domain.Common;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule
{
    public class Doctor : Entity<int>
    {
        public string Name { get; private set; }
    }
}
