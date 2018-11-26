using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution.MathOperation
{
    public class MeanAveraging : IMathOperation<IEnumerable<double>, double>
    {
        public double MakeMathOperation(IEnumerable<double> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException($"The {nameof(values)} can not be null.");
            }

            return values.ToList().Sum() / values.ToList().Count;
        }
    }
}
