using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    static class Initialization
    {
        public static List<User> CreateUsers()
        {
            var users = new List<User>()
        {
            new User() {Name = "Bob", Gender = "M", Age = 30},
            new User() {Name = "Tom", Gender = "M", Age = 23},
            new User() {Name = "Kate", Gender = "F", Age = 25},
            new User() {Name = "Lina", Gender = "F", Age = 56},
            new User() {Name = "Alex", Gender = "F", Age = 16},
            new User() {Name = "Mark", Gender = "M", Age = 17},
            new User() {Name = "John", Gender = "M", Age = 31},
            new User() {Name = "Sarah", Gender = "F", Age = 42},
            new User() {Name = "Emily", Gender = "F", Age = 25},
            new User() {Name = "Kevin", Gender = "M", Age = 23},
            new User() {Name = "Gary", Gender = "M", Age = 31},
            new User() {Name = "Lisa", Gender = "F", Age = 20},
        };
            return users;
        }
    }
}
