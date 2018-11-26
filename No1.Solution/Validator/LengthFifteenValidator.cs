using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Validator
{
    public class LengthFifteenValidator : IValidator
    {
        private string message;
        public string Message => message;

        public LengthFifteenValidator()
        {
            message = "Ok";
        }

        public bool VerifyPassword(string password)
        {
            // check if length more than 10 chars for admins
            if (password.Length >= 15)
            {
                message = $"{nameof(password)} length too long";
                return false;
            }

            return true;
        }
    }
}
