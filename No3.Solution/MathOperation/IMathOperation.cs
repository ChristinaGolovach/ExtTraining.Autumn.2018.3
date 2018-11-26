using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    public interface IMathOperation<in TInput, out TOutput>
    {
        TOutput MakeMathOperation(TInput values);
    }
}
