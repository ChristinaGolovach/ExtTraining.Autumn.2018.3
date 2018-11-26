using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Validator
{
    public class CompositeValidator : IValidator
    {
        private string message;
        public string Message => message;

        public CompositeValidator()
        {
            message = "Ok";
        }

        private IEnumerable<IValidator> validators;

        public CompositeValidator(IEnumerable<IValidator> validators)
        {
            this.validators = validators;                
        }

        public bool VerifyPassword(string password)
        {
            StringBuilder messages = new StringBuilder();

            foreach(var item in validators)
            {
                messages.Append(item.Message + Environment.NewLine);
            }           

            bool resultValidation = validators.All(v => v.VerifyPassword(password));

            return resultValidation;
        }
    }
}
