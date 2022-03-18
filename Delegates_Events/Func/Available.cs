using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    class Available
    {
        public static void AvailableAge(List<User> list)
        {
            var available = list.GroupBy(l => l.Age).Select(l => l.First()).OrderBy(l => l.Age);
            foreach (var user in available)
            {
                Console.Write($"{user.Age}; ");
            }
        }
    }
}
