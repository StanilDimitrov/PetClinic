using PetClinic.Domain.AppointmentsBoundedContext.Models.Shedules.Abstraction;
using System;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedules
{
    public class ExamRoom : BaseRoom
    {
        internal ExamRoom(int roomNumber) :
            base(roomNumber)
        {
        }
    }
}
