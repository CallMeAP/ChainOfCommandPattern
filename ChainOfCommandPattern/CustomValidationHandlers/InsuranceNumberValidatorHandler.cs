using ChainOfCommandPattern.CustomValidationLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfCommandPattern.CustomValidationHandlers
{
    public class InsuranceNumberValidatorHandler : Handler<User>
    {
        public override void Handle(User request)
        {
            if (!InsuranceNumberValidator.IsValidInsuranceNumber(request.InsurancNumber))
            {
                throw new Exception("Insurance number not valid!");
            }
            
            base.Handle(request);
        }
    }
}
