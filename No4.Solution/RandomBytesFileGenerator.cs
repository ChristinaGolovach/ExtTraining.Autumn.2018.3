using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public class RandomBytesFileGenerator : FileGenerator
    {
        private IRandomGenerator<int, byte[]> randomGenerator;

        public override string WorkingDirectory => "Files with random bytes";

        public override string FileExtension => ".bytes";

        public RandomBytesFileGenerator(IRandomGenerator<int, byte[]> randomGenerator)
        {
            this.randomGenerator = randomGenerator;
        }

        protected override byte[] GenerateFileContent(int contentLength)
        {
            return randomGenerator.Generate(contentLength);
        }
    }
}
