using System;

namespace LINQ
{
    class Program
    {
        private const string txtExtension = "txt";
        private const string csvExtension = "csv";
        private const string path = @"D:\EPAM_LABA\HomeTasks\LINQ\";
        private const string answerYes = "yes";
        private const string answerNo = "no";

        static void Main(string[] args)
        {
            Console.WriteLine($"Please choose file extension: {txtExtension} or {csvExtension}");
            string fileExtension;
            do
            {
                Console.Write("\nEnter:  ");
                fileExtension = Console.ReadLine().ToLower();
            } while (fileExtension != txtExtension && fileExtension != csvExtension);

            string answer;
            do
            {
                Console.WriteLine("\nPlease choose the name of the file from following:");
                var filesList = Files.GetFilesList(path, fileExtension);
                string fileName;
                do
                {
                    Console.Write("\nEnter:  ");
                    fileName = Console.ReadLine().ToLower();
                } while (!filesList.Contains(fileName));

                string filePath = $"{path}{fileName}.{fileExtension}";
                var numbersList = Output.FileOutput(fileExtension, filePath);

                Check.OddEvenCheck(numbersList, path, fileExtension);

                Console.WriteLine("\nDo you want to choose one more file? (Yes/no)");               
                do
                {
                    Console.Write("\nEnter:  ");
                    answer = Console.ReadLine().ToLower();
                } while (answer != answerYes && answer != answerNo); 
            } while (answer != answerNo);                       
        }
    }
}
