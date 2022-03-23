using EquationSolver;
using System;
using System.Collections.Generic;
using System.IO;

namespace Asynchrony_multithreading
{
    static class Output
    {
        public static List<Equation> FileOutput(string path)
        {
            var values = new List<Equation>();
            using (StreamReader streamReader = File.OpenText(path))
            {
                string text;
                while ((text = streamReader.ReadLine()) != null)
                {
                    string[] numbers = text.Split(' ');
                    int firstNumber = Convert.ToInt32(numbers[0]);
                    int secondNumber = Convert.ToInt32(numbers[1]);
                    int thirdNumber = Convert.ToInt32(numbers[2]);
                    var temp = new Equation() { A = firstNumber, B = secondNumber, C = thirdNumber };
                    values.Add(temp);
                }
            }
            return values;
        }
    }
}
