namespace PetClinic.Domain.Exceptions
{
    public class InvalidBasicRoomException : BaseDomainException
    {
        public InvalidBasicRoomException()
        {
        }

        public InvalidBasicRoomException(string error) => this.Error = error;
    }
}
