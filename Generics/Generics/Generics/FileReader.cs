using System;

namespace Generics
{
    class FileReader
    {
        public static T DecreaseCount<T>(string path) where T : Furniture
        {
            var data = Output.OutputData<T>(path);
            data.Count--;
            return data;
        }
    }
    class FileReader<T> where T : Person
    {
        public static T IncreaseAge(string path)
        {
            var data = Output.OutputData<T>(path);
            data.Age++;
            return data;
        }
    }
}
