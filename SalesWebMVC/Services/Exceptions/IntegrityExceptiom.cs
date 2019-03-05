using System;


namespace SalesWebMVC.Services.Exceptions
{
    public class IntegrityExceptiom : ApplicationException
    {
        public IntegrityExceptiom(string message) : base(message)
        {

        }
    }
}
