using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    public static class Filtering
    {
        public static List<User> AgeFilter(List<User> list, string age)
        {
            var filtered = new List<User>();
            filtered = list.Where(l => l.Age == int.Parse(age)).ToList();
            return filtered;
        }
        public static List<User> GenderFilter(List<User> list, string gender)
        {
            var filtered = new List<User>();
            filtered = list.Where(l => l.Gender == gender).ToList();
            return filtered;
        }
        public static List<User> Filter(Func<List<User>, string, List<User>> func, List<User> list, string variable)
        {
            return func(list, variable);
        }

    }
}
