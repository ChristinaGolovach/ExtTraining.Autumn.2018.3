using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private IRepository repository;
        private IValidator validator;

        public PasswordCheckerService(IRepository repository, IValidator validator)
        {
            this.repository = repository;
            this.validator = validator;
        }

        public (bool, string) VerifyPassword(string password)
        {
            if (!validator.VerifyPassword(password))
            {
                return (false, validator.Message);
            }

            repository.Create(password);

            return (true, "Password is Ok. User was created");
        }
    }
}
