using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Validator
{
    public class ContainsCharValidator : IValidator
    {
        private string message;
        public string Message => message;

        public ContainsCharValidator()
        {
            message = "Ok";
        }

        public bool VerifyPassword(string password)
        {
            // check if password contains at least one alphabetical character 
            if (!password.Any(char.IsLetter))
            {
                message = $"{nameof(password)} hasn't alphanumerical chars";
                return false;
            }

            return true;
        }
    }
}
