using System;
using System.Collections.Generic;
using System.Linq;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Initialization.CreateUsers();
            Console.WriteLine("Choose gender: M or F");
            string gender;
            do
            {
                Console.Write("\nEnter:  ");
                gender = Console.ReadLine().ToUpper();
            } while (gender != "M" && gender != "F");            

            var genderList = Filtering.Filter(Filtering.GenderFilter, list, gender);
            Console.Write("\nChoose the age from the following: ");
            Available.AvailableAge(genderList);

            string age;
            do
            {
                Console.Write("\n\nEnter:  ");
                age = Console.ReadLine();
            } while (!genderList.Exists(g => g.Age == int.Parse(age)));

            var ageList = Filtering.Filter(Filtering.AgeFilter, genderList, age);

            Console.WriteLine("\nYou have chosen: ");
            int num = 1;
            foreach(var user in ageList)
            {
                Console.WriteLine($"{num}. {user}");
                num++;
            }
        }
    }
}
