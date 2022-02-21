using System;
using System.Collections.Generic;
using System.Linq;

namespace TaxiDepot
{
    public class TaxiDepot
    {
        public const double MaxAvailableDistance = 50.0;
        public const double MinAvailableDistance = 1.0;
        public IList<Vehicle> AutoList { get; set; }

        public TaxiDepot (IList<Vehicle> autoList)
        {
            AutoList = autoList;
        }
        public TaxiDepot(Vehicle auto)
        {
            AutoList.Add(auto);
        }

        public decimal CostOfAutos()
        {
            decimal totalCost = 0;          
            foreach (var autoCost in AutoList)
            {
                totalCost += autoCost.Cost;
            }
            return totalCost;       
        }

        public void SortByFuel()
        {
            IList<Vehicle> sortedAutoList = AutoList.OrderBy(f => f.FuelRate).ToList();
            Console.Write("Sorted by fuel: ");
            for (int i = 0; i < sortedAutoList.Count; i++)
            {
                Console.Write($"{sortedAutoList[i].FuelRate}; ");
            }
        }
    }
}
