namespace PetClinic.Domain.Exceptions
{
    public class InvalidExamRoomException : BaseDomainException
    {
        public InvalidExamRoomException()
        {
        }

        public InvalidExamRoomException(string error) => this.Error = error;
    }
}
