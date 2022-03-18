using System;
using System.Linq;

namespace Delegate
{
    delegate string Fun(string s);
    class Program
    {
        delegate string Remaking(string s);

        public static void Main(String[] args)
        {
            Remaking re = null;
            re += Actions.CutString;
            re += Actions.RemoveAllSpacesFromEnd;
            re += Actions.AddDotsToEnd;

            Console.Write("Enter the line:  ");
            string line = Console.ReadLine();

            string result = line;
            foreach(Remaking d in re.GetInvocationList())
            {
                result = d.Invoke(result);
            }
            Console.WriteLine($"\nResult: {result}");
        }
    }
}
