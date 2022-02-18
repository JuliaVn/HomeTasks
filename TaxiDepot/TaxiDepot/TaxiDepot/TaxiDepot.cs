using System.Collections.Generic;
using System.Linq;

namespace TaxiDepot
{
    class TaxiDepot
    {
        public List<Vehicle> AutoList { get; }

        public TaxiDepot (List<Vehicle> AutoList)
        {
            this.AutoList = AutoList;
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
            List<Vehicle> sortedAutoList = AutoList.OrderBy(f => f.FuelRate).ToList();
        }
    }
}
