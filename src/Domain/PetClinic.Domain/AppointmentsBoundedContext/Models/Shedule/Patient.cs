using PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule.Enumerations;
using PetClinic.Domain.Common;
using PetClinic.Domain.SharedKernel;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule
{
    public class Patient : Entity<int>
    {
        public string Name { get; private set; }

        public PetType PetType { get; private set; }

        public Age Age { get; private set; }
    }
}
