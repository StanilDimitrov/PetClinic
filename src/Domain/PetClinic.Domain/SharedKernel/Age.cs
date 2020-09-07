using PetClinic.Domain.Common;

namespace PetClinic.Domain.SharedKernel
{
    public class Age : ValueObject
    {
        public int Years { get; private set; }

        public int Months { get;private set; }
    }
}
