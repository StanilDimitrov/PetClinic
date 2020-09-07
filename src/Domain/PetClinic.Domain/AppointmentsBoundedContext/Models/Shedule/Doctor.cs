using PetClinic.Domain.Common;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedule
{
    public class Doctor : Entity<int>
    {
        public Doctor(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }
    }
}
