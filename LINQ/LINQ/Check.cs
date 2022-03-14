using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    static class Check
    {
        public static void OddEvenCheck(IList<int> numbers, string pathOdd, string pathEven, string pathEqual, string fileExtension) 
        {
            int oddCount = 0;
            int evenCount = 0;
            var result = new List<long>();

            if (numbers != null && numbers.Count != 0)
            {
                foreach (var number in numbers)
                {
                    if (number % 2 == 0) evenCount++;
                    else oddCount++;
                }
                if (oddCount > evenCount)
                {
                    long multiplication = 1;
                    foreach (var number in numbers)
                    {
                        if (number == 0) continue;
                        multiplication *= number;
                    }
                    result.Add(multiplication);
                    Input.FileInput(result, pathOdd, fileExtension);
                }
                if (oddCount < evenCount)
                {
                    int sum = 0;
                    foreach (var number in numbers)
                    {
                        sum += number;
                    }
                    result.Add(sum);
                    Input.FileInput(result, pathEven, fileExtension);
                }
                if (oddCount == evenCount)
                {
                    result = numbers.OrderBy(p => p).Select(i => (long)i).ToList();
                    Input.FileInput(result, pathEqual, fileExtension);
                }
            }
        }
    }
}
