using No4.Solution.Generator;

namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FileGenerator byteFileGenerator = new RandomBytesFileGenerator(new RandomByteArray());
            byteFileGenerator.GenerateFiles(1, 12);

            FileGenerator charFileGenerator = new RandomCharsFileGenerator(new RandomString());
            charFileGenerator.GenerateFiles(1, 12);
        }
    }
}
