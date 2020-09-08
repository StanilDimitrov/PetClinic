namespace PetClinic.Domain.Exceptions
{
    public class InvalidScheduleException : BaseDomainException
    {
        public InvalidScheduleException()
        {
        }

        public InvalidScheduleException(string error) => this.Error = error;
    }
}
