
namespace TaxiDepot
{
    class Sedan : Vehicle
    {
        public Sedan(string vehicleModel, double vehicleFuelRate, decimal vehicleCost) : base(vehicleModel, vehicleFuelRate, vehicleCost)
        {
            Seats = 5;
            Fare = 2.3;
        }
    }
}
