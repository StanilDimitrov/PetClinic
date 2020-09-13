using PetClinic.Domain.Exceptions;
using System;

namespace PetClinic.Domain.Common
{
    public static class Guard
    {
        public static void AgainstEmptyString<TException>(string value, string name = "Value")
            where TException : BaseDomainException, new()
        {
            if (!string.IsNullOrEmpty(value))
            {
                return;
            }

            ThrowException<TException>($"{name} cannot be null ot empty.");
        }

        public static void ForStringLength<TException>(string value, int minLength, int maxLength, string name = "Value")
            where TException : BaseDomainException, new()
        {
            AgainstEmptyString<TException>(value, name);

            if (minLength <= value.Length && value.Length <= maxLength)
            {
                return;
            }

            ThrowException<TException>($"{name} must have between {minLength} and {maxLength} symbols.");
        }

        public static void AgainstOutOfRange<TException>(int number, int min, int max, string name = "Value")
            where TException : BaseDomainException, new()
        {
            if (min <= number && number <= max)
            {
                return;
            }

            ThrowException<TException>($"{name} must be between {min} and {max}.");
        }

        public static void AgainstOutOfRange<TException>(decimal number, decimal min, decimal max, string name = "Value")
            where TException : BaseDomainException, new()
        {
            if (min <= number && number <= max)
            {
                return;
            }

            ThrowException<TException>($"{name} must be between {min} and {max}.");
        }

        public static void AgainstInvalidEndDate<TException>(DateTime startDate, DateTime endDate)
           where TException : BaseDomainException, new()
        {
            if (endDate > startDate)
            {
                return;
            }

            ThrowException<TException>($"End date:'{endDate}' must be after start date:'{startDate}'.");
        }

        public static void AgainstInvalidStartDate<TException>(DateTime startDate)
          where TException : BaseDomainException, new()
        {
            if (startDate >= DateTime.Now)
            {
                return;
            }

            ThrowException<TException>($"Start date:'{startDate}' must be in the future.");
        }

        public static void AgainstInvalidAge<TException>(Age age)
          where TException : BaseDomainException, new()
        {
            if (age.Years< 0 && age.Years > 20)
            {
                ThrowException<TException>($"Years must be in the interval between 0 and 20");
            }

            if (age.Months < 0 && age.Months > 12)
            {
                ThrowException<TException>($"Months must be in the interval between 0 and 12");
            }
        }

        //public static void ForValidUrl<TException>(string url, string name = "Value")
        //    where TException : BaseDomainException, new()
        //{
        //    if (url.Length <= ModelConstants.Common.MaxUrlLength &&
        //        Uri.IsWellFormedUriString(url, UriKind.Absolute))
        //    {
        //        return;
        //    }

        //    ThrowException<TException>($"{name} must be a valid URL.");
        //}

        public static void Against<TException>(object actualValue, object unexpectedValue, string name = "Value")
            where TException : BaseDomainException, new()
        {
            if (!actualValue.Equals(unexpectedValue))
            {
                return;
            }

            ThrowException<TException>($"{name} must not be {unexpectedValue}.");
        }

        private static void ThrowException<TException>(string message)
            where TException : BaseDomainException, new()
        {
            var exception = new TException
            {
                Error = message
            };

            throw exception;
        }
    }
}
