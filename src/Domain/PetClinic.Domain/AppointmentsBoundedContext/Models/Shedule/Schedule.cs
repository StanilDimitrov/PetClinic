using PetClinic.Domain.Common;
using System.Collections.Generic;
using System.Linq;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule
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

    }
}
