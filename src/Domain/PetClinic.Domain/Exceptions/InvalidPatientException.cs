namespace PetClinic.Domain.Exceptions
{
    public class InvalidPatientException : BaseDomainException
    {
        public InvalidPatientException()
        {
        }

        public InvalidPatientException(string error) => this.Error = error;
    }
}
