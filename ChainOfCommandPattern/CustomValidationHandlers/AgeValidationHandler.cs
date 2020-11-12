using ChainOfCommandPattern.CustomValidationLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfCommandPattern.CustomValidationHandlers
{
    public class AgeValidationHandler : Handler<User>
    {
        public override void Handle(User request)
        {
            if (!AgeValidator.IsValidAge(AgeValidator.GetAge(request.DateOfBirth)))
            {
                throw new Exception("User has to be at least 18 years old!");
            }
            
            base.Handle(request);
        }
    }
}
