using PetClinic.Domain.Common;
using PetClinic.Domain.Exceptions;
using static PetClinic.Domain.Constants.CommonConstants;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule
{
    public class Doctor : Entity<int>
    {
        internal Doctor(string name)
        {
            this.Validate(name);

            this.Name = name;
        }

        public string Name { get; private set; }

        private void Validate(string name)
        => Guard.AgainstOutOfRange<InvalidDoctorException>(name.Length,MinNameLength, MaxNameLength, name);
    }
}
