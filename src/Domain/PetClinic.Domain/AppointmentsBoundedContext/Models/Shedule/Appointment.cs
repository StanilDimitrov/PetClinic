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

        public void AssignExamRoom(ExamRoom examRoom)
        {
            this.ExamRoom = examRoom;
        }

        private void Validate(DateTime startDate)
           => Guard.AgainstInvalidStartDate<InvalidAppointmentException>(startDate);

        private void Validate(DateTime startDate, DateTime endDate)
           => Guard.AgainstInvalidEndDate<InvalidAppointmentException>(startDate, endDate);
    }
}
