using System;
using System.Collections.Generic;
using System.IO;

namespace LINQ
{
    static class Output
    {
        public static IList<int> FileOutput(string fileExtension, string path)
        {
            var numbersList = new List<int>();
            using (StreamReader streamReader = File.OpenText(path))
            {
                string text;
                while ((text = streamReader.ReadLine()) != null)
                {
                    string[] numbers;
                    if (fileExtension == "txt") numbers = text.Split(' ');
                    else numbers = text.Split(',');
                    foreach(var number in numbers)
                    {
                        numbersList.Add(int.Parse(number));
                    }                   
                }
            }
            return numbersList;
        }
    }
}
