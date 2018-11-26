using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    public class Calculator
    {
        public double CalculateAverage(IEnumerable<double> values, IMathOperation<IEnumerable<double>, double> averagingMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException($"The {nameof(values)} can not be null.");
            }

            if (averagingMethod == null)
            {
                throw new ArgumentNullException($"The {nameof(averagingMethod)} can not be null.");
            }

            return CalculateAverage(values, averagingMethod.MakeMathOperation); 
        }

        public double CalculateAverage(IEnumerable<double> values, Func<IEnumerable<double>, double> averagingMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException($"The {nameof(values)} can not be null.");
            }

            if (averagingMethod == null)
            {
                throw new ArgumentNullException($"The {nameof(averagingMethod)} can not be null.");
            }

            return averagingMethod(values);
        }
    }
}
