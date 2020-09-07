using PetClinic.Domain.Common;
using PetClinic.Domain.Exceptions;
using System.Text.RegularExpressions;
using static PetClinic.Domain.Constants.PhoneNumberConstants;

namespace PetClinic.Domain.SharedKernel
{
    public class PhoneNumber : ValueObject
    {
        internal PhoneNumber(string number)
        {
            this.Validate(number);

            if (!Regex.IsMatch(number, PhoneNumberRegularExpression))
            {
                throw new InvalidPhoneNumberException("Phone number must start with a '+' and contain only digits afterwards.");
            }

            this.Number = number;
        }

        public string Number { get; }

        public static implicit operator string(PhoneNumber number) => number.Number;

        public static implicit operator PhoneNumber(string number) => new PhoneNumber(number);

        private void Validate(string phoneNumber)
            => Guard.ForStringLength<InvalidPhoneNumberException>(
                phoneNumber,
                MinPhoneNumberLength,
                MaxPhoneNumberLength,
                nameof(PhoneNumber));
    }
}
