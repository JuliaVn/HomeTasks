using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;
using EquationSolver;

namespace Asynchrony_multithreading
{   
    class Program
    {
        public const string path = @"D:\EPAM_LABA\HomeTasks\Asynchrony_multithreading\";
        
        static void Main(string[] args)
        {
            var time = new Stopwatch();
            var timeSpend = new List<string>();
            var list = Create.GetListOfEquation();
            Input.FileInput((path + "file.txt"), list);
            
            var values = Output.FileOutput((path + "file.txt"));
            var solver = new EqSolver();
            var outputs = new List<string>();

            Console.WriteLine("Resolving equations...");
            time.Start();
            foreach (var v in values)
            {
                var result = solver.ResolveEquation(v);
                outputs.Add(result.Result.Explanation);
            }
            Input.FileInput((path + "outputs.txt"), outputs);
            time.Stop();
            timeSpend.Add($"Time spend using 1 thread: {time.Elapsed}");
            Console.WriteLine($"Time spend using 1 thread: {time.Elapsed}");

            time.Restart();
            Parallel.ForEach(values, (v) =>
            {
                var result = solver.ResolveEquation(v);
                outputs.Add(result.Result.Explanation);
            });
            Input.FileInput((path + "outputs.txt"), outputs);
            time.Stop();
            timeSpend.Add($"Time spend using multithreading: {time.Elapsed}");
            Console.WriteLine($"Time spend using multithreading: {time.Elapsed}");

            Input.FileInput((path + "timeResult.txt"), timeSpend);
        }      
    }
}
