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
            return list.Where(l => l.Age == int.Parse(age)).ToList();
        }
        public static List<User> GenderFilter(List<User> list, string gender)
        {
            return list.Where(l => l.Gender == gender).ToList();
        }
        public static List<User> Filter(Func<List<User>, string, List<User>> func, List<User> list, string variable)
        {
            return func(list, variable);
        }

    }
}
