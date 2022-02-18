
namespace TaxiDepot
{
    public abstract class Vehicle
    {
        public const double MAX_AVAILABLE_DISTANCE = 50.0;
        public const double MIN_AVAILABLE_DISTANCE = 1.0;
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
