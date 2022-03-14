using System;
using System.IO;
using System.Collections.Generic;

namespace Collection
{
    static class Input
    {
        public static void FileInput(IList<long> resultList, string path, string fileExtension)
        {
            string newPath = $"{path}result.{fileExtension}";
            using var fileStream = new FileStream(newPath, FileMode.OpenOrCreate, FileAccess.Write);
            using var streamWriter = new StreamWriter(fileStream);
            foreach (var result in resultList)
            {
                streamWriter.WriteLine(result);
            }
        }
    }
}
