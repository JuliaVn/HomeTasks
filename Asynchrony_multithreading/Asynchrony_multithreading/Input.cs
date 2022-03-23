using EquationSolver;
using System;
using System.Collections.Generic;
using System.IO;

namespace Asynchrony_multithreading
{
    static class Input
    {
        public static void FileInput(string path, List<Equation> lines)
        {
            using var fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            using var streamWriter = new StreamWriter(fileStream);

            foreach (var l in lines)
            {
                streamWriter.WriteLine($"{l.A} {l.B} {l.C}");
            }
        }
        public static void FileInput(string path, List<string> lines)
        {
            using var fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            using var streamWriter = new StreamWriter(fileStream);

            foreach (var l in lines)
            {
                streamWriter.WriteLine(l);
            }
        }
    }
}
