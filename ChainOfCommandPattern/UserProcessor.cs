using ChainOfCommandPattern.CustomValidationHandlers;
using System;

namespace ChainOfCommandPattern
{
    internal class UserProcessor
    {
        //handler 
        public bool Register(User usr, out string message)
        {
            message = string.Empty;
            
            try
            {
                var handler = new InsuranceNumberValidatorHandler();

                // chain of handlers
                handler.SetNext(new AgeValidationHandler());
                handler.Handle(usr);
            }
            catch (Exception e)
            {
                message = e.Message;
                return false;
            }

            return true;
        }
    }
}