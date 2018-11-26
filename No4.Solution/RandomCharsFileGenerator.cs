using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public class RandomCharsFileGenerator : FileGenerator
    {
        private IRandomGenerator<int, string> randomGenerator;

        public override string WorkingDirectory => "Files with random chars";

        public override string FileExtension => ".txt";

        public RandomCharsFileGenerator(IRandomGenerator<int, string> randomGenerator)
        {
            this.randomGenerator = randomGenerator;
        }

        protected override byte[] GenerateFileContent(int contentLength)
        {
            string generatedString = randomGenerator.Generate(contentLength);

            var bytes = Encoding.Unicode.GetBytes(generatedString);

            return bytes;
        }
    }
}
