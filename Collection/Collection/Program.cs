using Collection;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileSystem
{
    class Program
    {
        private const string txtExtension = "txt";
        private const string csvExtension = "csv";
        private const string path = @"D:\EPAM_LABA\HomeTasks\Collection\";
        private const string newPath = @"D:\EPAM_LABA\HomeTasks\Collection\result.";
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

            var resultList = new List<long>();
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
                var sum = MathOperations.Sum(numbersList);
                var multiplication = MathOperations.Multiplication(numbersList);
                resultList.Add(sum);
                resultList.Add(multiplication);

                Console.WriteLine("\nDo you want to choose one more file? (Yes/no)");               
                do
                {
                    Console.Write("\nEnter:  ");
                    answer = Console.ReadLine().ToLower();
                } while (answer != answerYes && answer != answerNo); 
            } while (answer != answerNo);
            
            Input.FileInput(resultList, newPath, fileExtension);
        }
    }
}
