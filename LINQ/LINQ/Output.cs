using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQ
{
    static class Output
    {
        public static IList<int> FileOutput(string fileExtension, string path)
        {
            var numbersList = new List<int>();

            using (StreamReader streamReader = File.OpenText(path))
            {
                string text = streamReader.ReadToEnd();
                string[] numbers = fileExtension == "txt" ? text.Replace("\r\n", " ").Split(' ') : text.Replace("\r\n", ",").Split(',');
                numbersList = numbers.Select(number => int.Parse(number)).ToList();
            }
            return numbersList;
        }
    }
}
