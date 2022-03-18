using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    static class Actions
    {
        public static string AddDotsToEnd(string s)
        {
            return s + "...";
        }
        public static string RemoveAllSpacesFromEnd(string s)
        {
            string temp = s;
            while (temp[^1] == ' ')
            {
                temp = s.Remove(s.Length - 1);
            }
            return temp;
        }
        public static string CutString(string s)
        {
            if (s.Length < 12) return s;
            return s[..12];
        }
    }
}
