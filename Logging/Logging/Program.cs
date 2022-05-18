using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    class Program
    {
        delegate string Remaking(string s);
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public static Logger Logger => logger;
        public static void Main()
        {
            try
            {
                logger.Info("App is launching.");
                Remaking re = null;
                re += Actions.CutString;
                re += Actions.RemoveAllSpacesFromEnd;
                re += Actions.AddDotsToEnd;

                Console.Write("Enter the line:  ");
                string line = Console.ReadLine();

                foreach (Remaking d in re.GetInvocationList())
                {
                    line = d.Invoke(line);
                }
                Console.WriteLine($"\nResult: {line}");
                logger.Info("The operations have been finished.");
            }
            catch (Exception e)
            {
                logger.Error($"Something went wrong.Exception occured: {e.Message}");
            }
            LogManager.Shutdown();
        }
    }
}
