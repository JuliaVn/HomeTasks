using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    static class MathOperations
    {
        public static int Sum(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            Console.WriteLine($"\n\nSum of numbers {firstNumber} and {secondNumber} is {sum}.");
            return sum;
        }
        public static int Multiplication(int firstNumber, int secondNumber)
        {
            int multiplication = firstNumber * secondNumber;
            Console.WriteLine($"\nMultiplication of numbers {firstNumber} and {secondNumber} is {multiplication}.");
            return multiplication;
        }
        public static string Division(int firstNumber, int secondNumber)
        {
            string division;
            try
            {
                if (secondNumber == 0) throw new DivideByZeroException("\nThere is no possibility to divide by 0.");          
                division = Convert.ToString(firstNumber / (double)secondNumber);
                Console.WriteLine($"\nDivision of numbers {firstNumber} and {secondNumber} is {division}."); 
            }
            catch (DivideByZeroException e)
            {
                division = "divide by zero error";
                Console.WriteLine(e.Message);
            }
            return division;
        }
    }
}
