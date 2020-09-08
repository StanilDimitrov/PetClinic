using PetClinic.Domain.Common;
using PetClinic.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule
{
    public class Schedule : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Appointment> _appointments;

        private readonly HashSet<Surgery> _surgeries;

        internal Schedule()
        {
            _appointments = new HashSet<Appointment>();
            _surgeries = new HashSet<Surgery>();
        }

        public IReadOnlyCollection<Appointment> Appointments => _appointments.ToList().AsReadOnly();

        public void AddAppointment(Appointment appointment) => _appointments.Add(appointment);

        public IReadOnlyCollection<Surgery> Surgeries => _surgeries.ToList().AsReadOnly();

        public void AddSurgery(Surgery surgery) => _surgeries.Add(surgery);


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
            Appointment appointment,
            ExamRoom examRoom)
        {
            this.ValidateRoomAvailability(examRoom, appointment.StartDate, appointment.EndDate);
            appointment.AssignExamRoom(examRoom);
        }

        public void UpdateAppointment(
            Appointment appointment,
            Doctor doctor,
            ExamRoom examRoom,
            DateTime startDate,
            DateTime endDate)
        {
            this.ValidateDoctorAvailability(doctor, startDate, endDate);
            this.ValidateRoomAvailability(examRoom, startDate, endDate);
            appointment.UpdateAppointment(doctor, examRoom, startDate, endDate);
        }

        private void ValidateRoomAvailability(ExamRoom examRoom, DateTime startDate, DateTime endDate)
        {
            var isExamRoomAvailableForThePeriod = this.Appointments.Any(x => x.ExamRoom == examRoom && (startDate >= x.EndDate || endDate <= x.StartDate));

            if (!isExamRoomAvailableForThePeriod)
            {
                throw new InvalidScheduleException();
            }
        }

        private void ValidateDoctorAvailability(Doctor doctor, DateTime startDate, DateTime endDate)
        {
            var isExamRoomAvailableForThePeriod = this.Appointments.Any(x => x.Doctor == doctor && (startDate >= x.EndDate || endDate <= x.StartDate));

            if (!isExamRoomAvailableForThePeriod)
            {
                throw new InvalidScheduleException();
            }
        }
    }
}

