using System;
using System.Collections.Generic;
using System.IO;

namespace FileSystem
{
    static class Output
    {
        private static string path = @"D:\EPAM_LABA\HomeTasks\FileSystem\file.";
        public static IList<string> FileOutput(string fileExtension)
        {
            var lines = new List<string>();
            string temp = path + fileExtension;
            using (StreamReader streamReader = File.OpenText(temp))
            {
                string text;
                while ((text = streamReader.ReadLine()) != null)
                {
                    string[] numbers;
                    if (fileExtension == "txt") numbers = text.Split(' ');
                    else numbers = text.Split(',');

                    if (numbers != null)
                    {
                        int firstNumber = Convert.ToInt32(numbers[0]);
                        int secondNumber = Convert.ToInt32(numbers[1]);
                        int sum = MathOperations.Sum(firstNumber, secondNumber);
                        int multiplication = MathOperations.Multiplication(firstNumber, secondNumber);
                        string division = MathOperations.Division(firstNumber, secondNumber);                  
                        lines.Add($"{firstNumber}, {secondNumber}, {sum}, {multiplication}, {division}");
                    }
                }
            }
            return lines;
        }
    }
}
