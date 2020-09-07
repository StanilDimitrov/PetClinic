namespace PetClinic.Domain.Exceptions
{
    public class InvalidRecoveryRoomException : BaseDomainException
    {
        public InvalidRecoveryRoomException()
        {
        }

        public InvalidRecoveryRoomException(string error) => this.Error = error;
    }
}
