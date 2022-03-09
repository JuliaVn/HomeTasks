using System;
using System.IO;
using System.Collections.Generic;

namespace FileSystem
{
    class Input
    {
        public static void FileInput(string newPath, IList<string> lines)
        {
            if (!File.Exists(newPath))
            {
                using var fileStream = new FileStream(newPath, FileMode.Create, FileAccess.Write);
                using var streamWriter = new StreamWriter(fileStream);
                foreach (var line in lines)
                {
                    streamWriter.WriteLine(line);
                }
            }
        }
    }
}
