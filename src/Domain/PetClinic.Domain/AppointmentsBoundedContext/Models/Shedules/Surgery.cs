using PetClinic.Domain.AppointmentsBoundedContext.Models.Shedules.Abstraction;
using System;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedules
{
    public class Surgery : Appointment
    {
        internal Surgery(
          DateTime startDate,
          DateTime endDate,
          Doctor doctor,
          Patient patient,
          BaseRoom operationRoom,
          RecoveryRoom recoveryRoom) :
           base(startDate, endDate, doctor, patient, operationRoom)
        {
            this.RecoveryRoom = recoveryRoom;
        }

        private Surgery(
         DateTime startDate,
         DateTime endDate,
         Doctor doctor,
         Patient patient,
         BaseRoom operationRoom) :
          base(startDate, endDate, doctor, patient, operationRoom)
        {
            this.RecoveryRoom = default!;
        }

        public RecoveryRoom RecoveryRoom { get; set; }

        public override void UpdateAppointment(
            Doctor doctor,
            BaseRoom operationRoom,
            DateTime? startDate,
            DateTime? endDate,
            RecoveryRoom recoveryRoom = null)
        {
            base.UpdateAppointment(doctor, operationRoom, startDate, endDate);

            if (recoveryRoom != null)
            {
                this.RecoveryRoom = recoveryRoom;
            }
        }
    }
}
