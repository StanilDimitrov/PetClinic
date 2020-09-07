using PetClinic.Domain.Common;

namespace PetClinic.Domain.SharedKernel
{
    public class Client : Entity<int>
    {
        internal Client(string name, PhoneNumber phoneNumber)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }
        public string Name { get; private set; }

        public PhoneNumber PhoneNumber { get; private set; }

    }
}
