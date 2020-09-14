using PetClinic.Domain.AppointmentsBoundedContext.Models.Shedules.Enumerations;
using PetClinic.Domain.Common;
using PetClinic.Domain.SharedKernel;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedules
{
    public class Patient : Entity<int>
    {
        internal Patient(PetType petType, Age age, Client client)
        {
            this.PetType = petType;
            this.Age = age;
            this.Client = client;
        }

        private Patient()
        {
            this.PetType = default!;
            this.Age = default!;
            this.Client = default!;
        }

        public Client Client {get; private set;} 

        public PetType PetType { get; private set; }

        public Age Age { get; private set; }
    }
}
