using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    static class MathOperations
    {
        public static int Sum(IList<int> numbers)
        {
            int sum = 0;
            if(numbers != null && numbers.Count != 0)
            {
                foreach (var number in numbers)
                {
                    sum += number;
                }
            }
            return sum;
        }
        public static long Multiplication(IList<int> numbers)
        {
            long multiplication = 1;
            if (numbers != null && numbers.Count != 0)
            {
                foreach (var number in numbers)
                {
                    multiplication *= number;
                }
                return multiplication;
            }
            return 0;            
        }        
    }
}
