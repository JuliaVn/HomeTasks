
namespace TaxiDepot
{
    class Convertible : Vehicle
    {  
        public Convertible(string vehicleModel, double vehicleFuelRate, decimal vehicleCost) :base(vehicleModel, vehicleFuelRate, vehicleCost)
        {
            Seats = 4;
            Fare = 2.9;
        }
    }
}
