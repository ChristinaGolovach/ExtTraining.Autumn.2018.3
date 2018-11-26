using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Validator
{
    public class ContainsDigitValidator : IValidator
    {
        private string message;
        public string Message => message;

        public ContainsDigitValidator()
        {
            message = "Ok";
        }

        public bool VerifyPassword(string password)
        {
            if (!password.Any(char.IsNumber))
            {
                message = $"{nameof(password)} hasn't digits";
                return false;
            }

            return true;
        }

    }
}
