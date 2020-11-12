using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfCommandPattern.CustomValidationLogic
{
    public class AgeValidator
    {
        public static int GetAge(DateTimeOffset dateTimeOffset)
        {
            int result = 0;
            DateTime now = DateTime.Now;

            result = now.Year - dateTimeOffset.Year;

            if (now.Month < dateTimeOffset.Month)
            {
                result--;
            }

            return result;
        }

        public static bool IsValidAge(int age)
        {
            if (age < 18)
            {
                return false;
            }

            return true;
        }
    }
}
