using System;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose file extension: txt or csv");
            string fileExtension;
            do
            {
                Console.Write("\nEnter:  ");
                fileExtension = Console.ReadLine().ToLower();
            } while (fileExtension != "txt" && fileExtension != "csv");
            string path = $@"D:\EPAM_LABA\HomeTasks\FileSystem\file.{fileExtension}";

            var lines = Output.FileOutput(path, fileExtension);

            string newPath;
            if (fileExtension == "txt") newPath = $@"D:\EPAM_LABA\HomeTasks\FileSystem\output_{DateTime.Now.ToShortDateString()}.csv";
            else newPath = $@"D:\EPAM_LABA\HomeTasks\FileSystem\output_{DateTime.Now.ToShortDateString()}.txt";

            Input.FileInput(newPath, lines);
        }
    }
}
