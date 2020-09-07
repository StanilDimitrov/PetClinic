using System;
using System.Collections.Generic;
using System.Text;

namespace PetClinic.Domain.Exceptions
{
    public class InvalidRoomException : BaseDomainException
    {
        public InvalidRoomException()
        {
        }

        public InvalidRoomException(string error) => this.Error = error;
    }
}
