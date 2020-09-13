namespace PetClinic.Domain.Exceptions
{
    public class InvalidAgeException : BaseDomainException
    {
        public InvalidAgeException()
        {
        }

        public InvalidAgeException(string error) => this.Error = error;
    }
}
