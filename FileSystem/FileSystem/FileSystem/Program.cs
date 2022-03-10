using System;

namespace FileSystem
{
    class Program
    {
        private const string txtExtension = "txt";
        private const string csvExtension = "csv";
        static void Main(string[] args)
        {
            Console.WriteLine($"Please choose file extension: {txtExtension} or {csvExtension}");
            string fileExtension;
            do
            {
                Console.Write("\nEnter:  ");
                fileExtension = Console.ReadLine().ToLower();
            } while (fileExtension != txtExtension && fileExtension != csvExtension);

            var lines = Output.FileOutput(fileExtension);

            Input.FileInput(fileExtension, txtExtension, csvExtension, lines);
        }
    }
}
