using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution.Generator
{
    public class RandomByteArray : IRandomGenerator<int, byte[]>
    {
        public byte[] Generate(int length)
        {
            var random = new Random();

            var fileContent = new byte[length];

            random.NextBytes(fileContent);

            return fileContent;
        }
    }
}
