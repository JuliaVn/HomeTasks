using System;
using System.Collections.Generic;
using System.IO;

namespace FileSystem
{
    class Output
    {
        public static IList<string> FileOutput(string path, string fileExtension)
        {
            var lines = new List<string>();
            using (StreamReader streamReader = File.OpenText(path))
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
                        int sum = firstNumber + secondNumber;
                        Console.WriteLine($"\n\nSum of numbers {firstNumber} and {secondNumber} is {sum}.");
                        int multiplication = firstNumber * secondNumber;
                        Console.WriteLine($"\nMultiplication of numbers {firstNumber} and {secondNumber} is {multiplication}.");
                        string division;     
                        if (secondNumber == 0)
                        {
                            division = "divide by zero error";
                            Console.WriteLine("\nThere is no possibility to divide by 0.");                
                        }
                        else
                        {
                            division = Convert.ToString(firstNumber / (double)secondNumber);
                            Console.WriteLine($"\nDivision of numbers {firstNumber} and {secondNumber} is {division}.");
                        }                       
                        
                        lines.Add($"{firstNumber}, {secondNumber}, {sum}, {multiplication}, {division}");
                    }
                }
            }
            return lines;
        }
    }
}
