using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    class Actions
    {
        private static readonly Logger logger = Program.Logger;
        public static string AddDotsToEnd(string s)
        {
            logger.Trace("Adding dots to the end of the string.");
            return s + "...";
        }
        public static string RemoveAllSpacesFromEnd(string s)
        {
            logger.Trace("Removing all spaces from the end of the string.");
            string temp = s;
            while (temp[^1] == ' ')
            {
                temp = s.Remove(s.Length - 1);
            }
            return temp;
        }
        public static string CutString(string s)
        {
            if (s.Length < 12)
            {
                logger.Trace("Returned the string since there are less than 12 symbols.");
                return s;               
            }
            else
            {
                logger.Trace("Cutting the string till 12th symbol.");
                return s[..12];
            }          
        }
    }
}
