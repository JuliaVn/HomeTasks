
namespace TaxiDepot
{
    class PickupTruck : Vehicle
    {
        public PickupTruck(string vehicleModel, double vehicleFuelRate, decimal vehicleCost) : base(vehicleModel, vehicleFuelRate, vehicleCost)
        {
            Seats = 5;
            Fare = 2.5;
        }

    }
}
