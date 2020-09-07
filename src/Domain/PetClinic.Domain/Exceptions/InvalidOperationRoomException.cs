namespace PetClinic.Domain.Exceptions
{
    public class InvalidOperationRoomException : BaseDomainException
    {
        public InvalidOperationRoomException()
        {
        }

        public InvalidOperationRoomException(string error) => this.Error = error;
    }
}
