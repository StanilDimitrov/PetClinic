using PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule.Abstraction;
using System;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule
{
    public class ExamRoom : BaseRoom
    {
        internal ExamRoom(int roomNumber) :
            base(roomNumber)
        {
        }
    }
}
