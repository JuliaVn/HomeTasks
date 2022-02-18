
namespace TaxiDepot
{
    class Minivan : Vehicle
    {
        public Minivan(string vehicleModel, double vehicleFuelRate, decimal vehicleCost) : base(vehicleModel, vehicleFuelRate, vehicleCost)
        {
            Seats = 8;
            Fare = 2.4;
        }
    }
}
