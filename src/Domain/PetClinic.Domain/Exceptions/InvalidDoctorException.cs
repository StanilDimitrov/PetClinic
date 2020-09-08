namespace PetClinic.Domain.Exceptions
{
    public class InvalidDoctorException : BaseDomainException
    {
        public InvalidDoctorException()
        {
        }

        public InvalidDoctorException(string error) => this.Error = error;
    }
}
