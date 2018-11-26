using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public interface IValidator
    {
       string Message { get; }
       bool VerifyPassword(string password);
    }
}
