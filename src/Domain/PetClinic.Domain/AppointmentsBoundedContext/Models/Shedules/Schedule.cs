using PetClinic.Domain.AppointmentsBoundedContext.Models.Shedules.Abstraction;
using PetClinic.Domain.Common;
using PetClinic.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedules
{
    public class Schedule : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Appointment> _appointments;

        internal Schedule()
        {
            _appointments = new HashSet<Appointment>();
        }

        public IReadOnlyCollection<Appointment> Appointments => _appointments.ToList().AsReadOnly();

        public void AddAppointment(Appointment appointment) => _appointments.Add(appointment);

        public void AssignDoctor(Appointment appointment, Doctor doctor)
        {
            this.ValidateDoctorAvailability(doctor, appointment.StartDate, appointment.EndDate);
            appointment.AssignDoctor(doctor);
        }

        public void AssignPatient(Appointment appointment, Patient patient)
        {
            appointment.AssignPatient(patient);
        }

        public void AssignExamRoom(
            OfficeVisit appointment,
            ExamRoom examRoom)
        {
            this.ValidateRoomAvailability(examRoom, appointment.StartDate, appointment.EndDate);
            appointment.AssignRoom(examRoom);
        }

        public void AssignOperationRoom(
           Surgery appointment,
           OperationRoom operationRoom)
        {
            this.ValidateRoomAvailability(operationRoom, appointment.StartDate, appointment.EndDate);
            appointment.AssignRoom(operationRoom);
        }

        public void AssignRecoveryRoom(
          Surgery appointment,
          RecoveryRoom recoveryRoom)
        {
            this.ValidateRoomAvailability(recoveryRoom, appointment.StartDate, appointment.EndDate);
            appointment.AssignRoom(recoveryRoom);
        }

        public void UpdateAppointment(
            Appointment appointment,
            Doctor doctor,
            BaseRoom baseRoom,
            DateTime startDate,
            DateTime endDate,
            RecoveryRoom recoveryRoom = null)
        {
            this.ValidateDoctorAvailability(doctor, startDate, endDate);
            this.ValidateRoomAvailability(baseRoom, startDate, endDate);
            this.ValidateRoomAvailability(recoveryRoom, startDate, endDate);

            appointment.UpdateAppointment(doctor, baseRoom, startDate, endDate, recoveryRoom);
        }

        private void ValidateRoomAvailability(BaseRoom baseRoom, DateTime startDate, DateTime endDate)
        {
            var isRoomAvailableForThePeriod = this.Appointments.Any(x => x.BaseRoom == baseRoom && (startDate >= x.EndDate || endDate <= x.StartDate));

            if (!isRoomAvailableForThePeriod)
            {
                throw new InvalidScheduleException();
            }
        }

        private void ValidateDoctorAvailability(Doctor doctor, DateTime startDate, DateTime endDate)
        {
            var isDoctorAvailableForThePeriod = this.Appointments.Any(x => x.Doctor == doctor && (startDate >= x.EndDate || endDate <= x.StartDate));

            if (!isDoctorAvailableForThePeriod)
            {
                throw new InvalidScheduleException();
            }
        }
    }
}

