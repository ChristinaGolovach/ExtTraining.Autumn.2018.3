using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Validator
{
    public class LengthSevenValidator : IValidator
    {
        private string message;
        public string Message => message;

        public LengthSevenValidator()
        {
            message = "Ok";
        }

        public bool VerifyPassword(string password)
        {
            // check if length more than 7 chars 
            if (password.Length <= 7)
            {
                message = $"{nameof(password)} length too short";
                return false;
            }
            return true;
        }
    }
}
