using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public interface IRandomGenerator<in TInput, out TOutput>
    {
        TOutput Generate(TInput length);
    }
}
