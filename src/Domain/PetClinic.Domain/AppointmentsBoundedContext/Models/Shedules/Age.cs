using PetClinic.Domain.Common;
using PetClinic.Domain.Exceptions;
using static PetClinic.Domain.Constants.PatientConstants;

namespace PetClinic.Domain.AppointmentsBoundedContext.Models.Shedules
{
    public class Age : ValueObject
    {
        internal Age(int years, int months)
        {
            this.ValidateYears(years);
            this.ValidateMonths(months);

            this.Years = years;
            this.Months = months;
        }
        public int Years { get; private set; }

        public int Months { get;private set; }

        private void ValidateMonths(int months)
       => Guard.AgainstOutOfRange<InvalidAgeException>(months, MinAgeMonths, MaxAgeMonths, "Months");

        private void ValidateYears(int years)
    => Guard.AgainstOutOfRange<InvalidAgeException>(years, MinAgeYears, MaxAgeYears, "Years");
    }
}
