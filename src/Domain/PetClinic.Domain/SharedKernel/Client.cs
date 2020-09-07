using PetClinic.Domain.Common;

namespace PetClinic.Domain.SharedKernel
{
    public class Client : Entity<int>
    {
        public string Name { get; private set; }

        public PhoneNumber PhoneNumber { get; private set; }

    }
}
