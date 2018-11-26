using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Validator
{
    public class DefaultEmptyValidator : IValidator
    {
        private string message;
        public string Message => message;

        public DefaultEmptyValidator()
        {
            message = "Ok";
        }
        public bool VerifyPassword(string password)
        {
            if (password == string.Empty)
            {
                message = $"{nameof(password)} is empty";
                return false;
            }

            return true;
        }
    }
}
