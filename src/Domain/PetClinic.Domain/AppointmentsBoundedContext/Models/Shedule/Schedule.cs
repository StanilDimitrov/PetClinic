using PetClinic.Domain.Common;
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
    }
}
