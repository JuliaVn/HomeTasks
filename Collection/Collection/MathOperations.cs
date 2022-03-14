using System;
using System.Collections.Generic;

namespace Collection
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
