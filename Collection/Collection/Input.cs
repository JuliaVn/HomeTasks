using System;
using System.IO;
using System.Collections.Generic;

namespace FileSystem
{
    static class Input
    {
        public static void FileInput(IList<long> resultList, string newPath, string fileExtension)
        {
            string path = newPath + fileExtension;
            if (!File.Exists(path))
            {
                using var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                using var streamWriter = new StreamWriter(fileStream);
                foreach (var result in resultList)
                {
                    streamWriter.WriteLine(result);
                }
            }
        }
    }
}
