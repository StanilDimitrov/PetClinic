using PetClinic.Domain.Common;
using System;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule
{
    public class Appointment : Entity<int>
    {
        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public Doctor Doctor { get; private set; }

        public Patient Patient { get; private set; }

        public ExamRoom ExamRoom { get; private set; }
    }
}
