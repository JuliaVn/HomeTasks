using EquationSolver;
using System;
using System.Collections.Generic;

namespace Asynchrony_multithreading
{
    static class Create
    {
        public static List<Equation> GetListOfEquation()
        {
            var list = new List<Equation>();
            var random = new Random();
            for (int i = 0; i < 1200; i++)
            {
                var eq = new Equation() { A = random.Next(1, 50), B = random.Next(1, 50), C = random.Next(1, 50) };
                list.Add(eq);
            }
            return list;
        }
    }
}
