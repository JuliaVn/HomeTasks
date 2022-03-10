using System;
using System.IO;
using System.Collections.Generic;

namespace FileSystem
{
    static class Input
    {
        private static string newPath = $@"D:\EPAM_LABA\HomeTasks\FileSystem\output_{DateTime.Now.ToShortDateString()}.";

        public static string getNewPath(string fileExtension, string txtExtension, string csvExtension)
        {
            string path;
            if (fileExtension == txtExtension) path = newPath + csvExtension;
            else path = newPath + txtExtension;
            return path;
        }
        public static void FileInput(string fileExtension, string txtExtension, string csvExtension, IList<string> lines)
        {
            string path = getNewPath(fileExtension, txtExtension, csvExtension);
            if (!File.Exists(path))
            {
                using var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                using var streamWriter = new StreamWriter(fileStream);
                foreach (var line in lines)
                {
                    streamWriter.WriteLine(line);
                }
            }
        }
    }
}
