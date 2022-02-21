
namespace TaxiDepot
{
    public abstract class Vehicle
    {
        public string Model { get; }
        public double FuelRate { get; }
        public decimal Cost { get; }
        public int Seats { get; set; }
        public double Fare { get; set; }

        public Vehicle(string vehicleModel, double vehicleFuelRate, decimal vehicleCost)
        {
            Model = vehicleModel;
            FuelRate = vehicleFuelRate;    
            Cost = vehicleCost;
        }
    }
}
