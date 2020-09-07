using PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule.Enumerations;
using PetClinic.Domain.Common;
using PetClinic.Domain.Exceptions;
using PetClinic.Domain.SharedKernel;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule
{
    public class Patient : Entity<int>
    {
        internal Patient(PetType petType, Age age, Client client)
        {
            this.Validate(age);

            this.PetType = petType;
            this.Age = age;
            this.Client = client;
        }

        public Client Client {get; private set;} 

        public PetType PetType { get; private set; }

        public Age Age { get; private set; }

        private void Validate(Age age)
          => Guard.AgainstInvalidAge<InvalidPatientException>(age);
    }
}
