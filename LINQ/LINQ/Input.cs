using System;
using System.IO;
using System.Collections.Generic;

namespace LINQ
{
    static class Input
    {
        public static void FileInput(IList<long> resultList, string path)
        {
            using var fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            using var streamWriter = new StreamWriter(fileStream);
            foreach (var result in resultList)
            {
                streamWriter.WriteLine(result);
            }
        }
    }
}
