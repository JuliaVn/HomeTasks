using System;
using System.Collections.Generic;
using System.IO;

namespace LINQ
{
    static class Files
    {
        public static IList<string> GetFilesList(string path, string fileExtension)
        {
            var di = new DirectoryInfo(path);
            FileInfo[] files = di.GetFiles($"*.{fileExtension}");
            var filesList = new List<string>();
            foreach (FileInfo file in files)
            {
                if (file.Name.Contains("result")) continue;
                Console.WriteLine(Path.GetFileNameWithoutExtension(file.Name));
                filesList.Add(Path.GetFileNameWithoutExtension(file.Name));
            }
            return filesList;
        }
    }
}
