using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDepot
{
    class Parameters
    {
        public static void ShowAvailableSeats(IList<Vehicle> autoList)
        {
            SortedSet<int> available = new SortedSet<int>();
            for (int i = 0; i < autoList.Count; i++)
            {
                available.Add(autoList[i].Seats);
            }
            foreach (var seat in available)
            {
                Console.Write($"{seat}; ");
            }
        }

        public static void ShowAvailableModel(IList<Vehicle> autoList)
        {
            SortedSet<string> available = new SortedSet<string>();
            for (int i = 0; i < autoList.Count; i++)
            {
                available.Add(autoList[i].Model);
            }
            int number = 1;
            foreach (var model in available)
            {
                Console.WriteLine($"{number}. {model}");
                number++;
            }
        }

        public static void ShowAvailableFare(IList<Vehicle> autoList)
        {
            SortedSet<double> available = new SortedSet<double>();
            for (int i = 0; i < autoList.Count; i++)
            {
                available.Add(autoList[i].Fare);
            }
            foreach (var fare in available)
            {
                Console.Write($"{fare}; ");
            }
        }

        public static IList<Vehicle> GetExistingParameters(IList<Vehicle> autoList, int capacity)
        {
            var autoListBySeats = (autoList as List<Vehicle>).FindAll((Vehicle auto) => auto.Seats == capacity);
            if (autoListBySeats.Count == 0) Console.WriteLine("\nPlease enter valid value!");
            return autoListBySeats;
        }

        public static IList<Vehicle> GetExistingParameters(IList<Vehicle> autoList, string model)
        {
            var autoListByModel = (autoList as List<Vehicle>).FindAll((Vehicle auto) => auto.Model.ToLower() == model.ToLower());
            if (autoListByModel.Count == 0) Console.WriteLine("\nPlease enter valid value!");
            return autoListByModel;
        }

        public static IList<Vehicle> GetExistingParameters(IList<Vehicle> autoList, double fare)
        {
            var autoListByFare = (autoList as List<Vehicle>).FindAll((Vehicle auto) => auto.Fare == fare);
            if (autoListByFare.Count == 0) Console.WriteLine("\nPlease enter valid value!");
            return autoListByFare;
        }

        public static double CountDistance(double distance, double fare)
        {
            if (TaxiDepot.MinAvailableDistance > distance) Console.WriteLine("\nWe are not able to ride negative distance or less than 1 km. Please enter the distance greater than 1 km.");
            if (distance > TaxiDepot.MaxAvailableDistance) Console.WriteLine("\nWe are not able to ride too long distance. Please enter the distance from 1 km to 50 km.");
            return distance * fare;
        }
    }
}
