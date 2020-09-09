using PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule.Abstraction;
using System;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule
{
    public class OfficeVisit : Appointment
    {
        internal OfficeVisit(
           DateTime startDate,
           DateTime endDate,
           Doctor doctor,
           Patient patient,
           BaseRoom baseRoom) :
            base(startDate, endDate, doctor, patient, baseRoom)
        {
        }

        public override void UpdateAppointment(
            Doctor doctor,
            BaseRoom examRoom,
            DateTime? startDate, 
            DateTime? endDate, 
            RecoveryRoom recoveryRoom = null)
        {
            base.UpdateAppointment(doctor, examRoom, startDate, endDate);
        }
    }
}
