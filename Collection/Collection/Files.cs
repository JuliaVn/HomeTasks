﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
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
                Console.WriteLine(Path.GetFileNameWithoutExtension(file.Name));
                filesList.Add(Path.GetFileNameWithoutExtension(file.Name));
            }
            return filesList;
        }
    }
}
