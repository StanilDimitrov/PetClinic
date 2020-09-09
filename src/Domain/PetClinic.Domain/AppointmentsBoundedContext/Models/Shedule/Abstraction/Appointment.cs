using PetClinic.Domain.Common;
using PetClinic.Domain.Exceptions;
using System;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule.Abstraction
{
    public abstract class Appointment : Entity<int>
    {
        protected Appointment(
           DateTime startDate,
           DateTime endDate,
           Doctor doctor,
           Patient patient,
           BaseRoom baseRoom)
        {
            this.Validate(startDate);
            this.Validate(startDate, endDate);

            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Doctor = doctor;
            this.Patient = patient;
            this.BaseRoom = baseRoom;
        }
        public DateTime StartDate { get; protected set; }

        public DateTime EndDate { get; protected set; }

        public Doctor Doctor { get; protected set; }

        public Patient Patient { get; protected set; }

        public BaseRoom BaseRoom { get; protected set; }

        public virtual void UpdateAppointment(
            Doctor doctor,
            BaseRoom baseRoom,
            DateTime? startDate,
            DateTime? endDate,
            RecoveryRoom recoveryRoom = null)
        {
            SetAppointment(doctor, baseRoom, startDate, endDate);
        }

        public virtual void AssignDoctor(Doctor doctor)
        {
            this.Doctor = doctor;
        }

        public virtual void AssignPatient(Patient patient)
        {
            this.Patient = patient;
        }

        public virtual void AssignRoom(BaseRoom baseRoom)
        {
            this.BaseRoom = baseRoom;
        }

        private void SetAppointment(
            Doctor doctor,
            BaseRoom baseRoom,
            DateTime? startDate,
            DateTime? endDate)
        {
            if (doctor != null)
            {
                this.Doctor = doctor;
            }

            if (baseRoom != null)
            {
                this.BaseRoom = baseRoom;
            }

            if (startDate.HasValue)
            {
                this.StartDate = startDate.Value;
            }

            if (endDate.HasValue)
            {
                this.EndDate = endDate.Value;
            }
        }

        private void Validate(DateTime startDate)
          => Guard.AgainstInvalidStartDate<InvalidAppointmentException>(startDate);

        private void Validate(DateTime startDate, DateTime endDate)
           => Guard.AgainstInvalidEndDate<InvalidAppointmentException>(startDate, endDate);
    }
}
