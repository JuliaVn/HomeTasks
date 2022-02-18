
namespace TaxiDepot
{
    class SportsCar : Vehicle
    {
        public SportsCar(string vehicleModel, double vehicleFuelRate, decimal vehicleCost) : base(vehicleModel, vehicleFuelRate, vehicleCost)
        {
            Seats = 2;
            Fare = 2.8;
        }
    }
}
