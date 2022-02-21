using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDepot
{
    public static class Initialization
    {
        public static IList<Vehicle> GetAutoList()
        {
            Vehicle auto1 = new Convertible("Mazda", 8.0, 5000);
            Vehicle auto2 = new Convertible("Ford", 4.3, 7500);
            Vehicle auto3 = new Minivan("Toyota", 5.0, 3000);
            Vehicle auto4 = new Minivan("Honda", 5.5, 3500);
            Vehicle auto5 = new Sedan("BMW", 6.5, 10000);
            Vehicle auto6 = new Sedan("Audi", 6.0, 9000);
            Vehicle auto7 = new PickupTruck("Audi", 7.0, 8000);
            Vehicle auto8 = new PickupTruck("Ford", 6.0, 11000);
            Vehicle auto9 = new SportsCar("BMW", 7.5, 4000);
            Vehicle auto10 = new SportsCar("Mazda", 8.0, 10500);            

            var autoList = new List<Vehicle>() { auto1, auto2, auto3, auto4, auto5, auto6, auto7, auto8, auto9, auto10 };
            return autoList;
        }
        public static Vehicle GetAuto()
        {
            return new SportsCar("BMW", 8.5, 3500);
        }
        public static TaxiDepot GetTaxiDepot()
        {
            TaxiDepot taxiDepot1 = new TaxiDepot(GetAutoList());
            return taxiDepot1;        
        }
    }
}

