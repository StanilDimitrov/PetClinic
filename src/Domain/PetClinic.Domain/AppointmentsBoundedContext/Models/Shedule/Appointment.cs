using PetClinic.Domain.Common;
using PetClinic.Domain.Exceptions;
using System;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule
{
    public class Appointment : Entity<int>
    {
        internal Appointment(
            DateTime startDate,
            DateTime endDate,
            Doctor doctor,
            Patient patient,
            ExamRoom examRoom)
        {
            this.Validate(startDate);
            this.Validate(startDate, endDate);

            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Doctor = doctor;
            this.Patient = patient;
            this.ExamRoom = examRoom;
        }
        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public Doctor Doctor { get; private set; }

        public Patient Patient { get; private set; }

        public ExamRoom ExamRoom { get; private set; }

        public void AssignDoctor(Doctor doctor)
        {
            this.Doctor = doctor;
        }

        public void AssignPatient(Patient patient)
        {
            this.Patient = patient;
        }

        public void AssignExamRoom(ExamRoom examRoom)
        {
            this.ExamRoom = examRoom;
        }

        public void UpdateAppointment(
            Doctor doctor,
            ExamRoom examRoom,
            DateTime? startDate,
            DateTime? endDate)
        {
            SetAppointment(doctor, examRoom, startDate, endDate);
        }

        private void SetAppointment(
            Doctor doctor,
            ExamRoom examRoom,
            DateTime? startDate,
            DateTime? endDate)
        {
            if (doctor != null)
            {
                this.Doctor = doctor;
            }

            if (examRoom != null)
            {
                this.ExamRoom = examRoom;
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
