using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    static class Check
    {
        public static void OddEvenCheck(IList<int> numbers, string path, string fileExtension) 
        {
            int evenCount = numbers.Where(number => number % 2 == 0).Count();
            int oddCount = numbers.Where(number => number % 2 != 0).Count();
            var result = new List<long>();

            if (numbers != null && numbers.Count != 0)
            {
                if (oddCount > evenCount)
                {
                    long multiplication = 1;
                    foreach (var number in numbers)
                    {
                        if (number == 0) continue;
                        multiplication *= number;
                    }
                    result.Add(multiplication);
                    string pathOdd = $"{path}result_odd_numbers.{fileExtension}";
                    Input.FileInput(result, pathOdd);
                } else if (oddCount < evenCount)
                {
                    int sum = numbers.Sum();
                    result.Add(sum);
                    string pathEven = $"{path}result_even_numbers.{fileExtension}";
                    Input.FileInput(result, pathEven);
                } else
                {
                    result = numbers.OrderBy(p => p).Select(i => (long)i).ToList();
                    string pathEqual = $"{path}result_equal_numbers.{fileExtension}";
                    Input.FileInput(result, pathEqual);
                }
            }
        }
    }
}
