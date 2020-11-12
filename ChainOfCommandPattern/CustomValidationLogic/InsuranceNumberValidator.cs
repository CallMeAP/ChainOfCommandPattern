using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfCommandPattern.CustomValidationLogic
{
    public class InsuranceNumberValidator
    {

        public static bool IsValidInsuranceNumber(string insuranceNumber)
        {
            if (insuranceNumber.Length != 12)
            {
                return false;
            }

            return true;
        }
    }
}
