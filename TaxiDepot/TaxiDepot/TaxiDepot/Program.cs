using System;
using System.Collections.Generic;
using System.Globalization;

namespace TaxiDepot
{
    class Program
    {       
        static void Main(string[] args)
        {        
            Convertible auto1 = new Convertible("Mazda", 8.0, 5000);
            Convertible auto2 = new Convertible("Ford", 4.3, 7500);
            Minivan auto3 = new Minivan("Toyota", 5.0, 3000);
            Minivan auto4 = new Minivan("Honda", 5.5, 3500);
            Sedan auto5 = new Sedan("BMW", 6.5, 10000);
            Sedan auto6 = new Sedan("Audi", 6.0, 9000);
            PickupTruck auto7 = new PickupTruck("Audi", 7.0, 8000);
            PickupTruck auto8 = new PickupTruck("Ford", 6.0, 11000);
            SportsCar auto9 = new SportsCar("BMW", 7.5, 4000);
            SportsCar auto10 = new SportsCar("Mazda", 8.0, 10500);

            List<Vehicle> autoList = new List<Vehicle>();
            autoList.Add(auto1);
            autoList.Add(auto2);
            autoList.Add(auto3);
            autoList.Add(auto4);
            autoList.Add(auto5);
            autoList.Add(auto6);
            autoList.Add(auto7);
            autoList.Add(auto8);
            autoList.Add(auto9);
            autoList.Add(auto10);

            TaxiDepot taxiDepot = new TaxiDepot(autoList);
            taxiDepot.CostOfAutos();
            taxiDepot.SortByFuel();
            
            try
            {
                Console.WriteLine("Please enter vehicle capacity you are needed from the following:\t");
                SortedSet<int> availableCapacity = new SortedSet<int>();
                for (int i = 0; i < autoList.Count; i++)
                {
                    availableCapacity.Add(autoList[i].Seats);
                }
                int number = 1;
                foreach (var seat in availableCapacity)
                {                    
                    Console.WriteLine($"{number}. {seat} seats");
                    number++;
                }
                Console.Write("\nEnter:\t");
                int capacity = int.Parse(Console.ReadLine());
                List<Vehicle> autoListBySeats = autoList.FindAll((Vehicle auto) => auto.Seats == capacity);
                if (autoListBySeats.Count == 0) throw new Exception($"{capacity} number of seats not available. Please chose the number from list above");


                Console.WriteLine("\nPlease choose model of the vehicle from the following:\t");                
                for (int i = 0; i < autoListBySeats.Count; i++)
                {                    
                    Console.WriteLine($"{i + 1}. {autoListBySeats[i].Model}");
                }
                Console.Write("\nEnter:\t");
                string model = Console.ReadLine();
                List<Vehicle> modelOfVehicleList = autoListBySeats.FindAll((Vehicle auto) => auto.Model.ToLower() == model.ToLower());
                if(modelOfVehicleList.Count == 0) throw new Exception($"Please enter model from list above.");

                double taxiFare = 0;
                if (modelOfVehicleList.Count >= 2)
                {
                    Console.WriteLine("\nPlease chose the vehicle of the following:");
                    for (int i = 0; i < modelOfVehicleList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. Model {modelOfVehicleList[i].Model} with taxi fare {modelOfVehicleList[i].Fare}");
                    }
                    Console.Write("\nEnter taxi rate:\t");
                    double fare = double.Parse(Console.ReadLine());
                    List<Vehicle> fareOfVehicleList = modelOfVehicleList.FindAll((Vehicle auto) => auto.Fare == fare);
                    if (fareOfVehicleList.Count == 0) throw new Exception($"Please enter taxi rate from list above.");
                    Console.WriteLine($"\nYou have chosen {fareOfVehicleList[0].Model} with taxi fare {fare}.");
                    taxiFare = fare;
                } else
                {
                    Console.WriteLine($"\nYou have chosen {modelOfVehicleList[0].Model} with taxi fare {modelOfVehicleList[0].Fare}.");
                    taxiFare = modelOfVehicleList[0].Fare;
                }

                Console.Write("\nPlease enter the distance you need:\t");
                double distance = double.Parse(Console.ReadLine());
                if (Vehicle.MIN_AVAILABLE_DISTANCE > distance) throw new Exception("We are not able to ride negative distance or less than 1 km. Please enter the distance greater than 1 km.");
                if (distance > Vehicle.MAX_AVAILABLE_DISTANCE) throw new Exception("We are not able to ride too long distance. Please enter the distance in range from 1 km to 50 km.");

                double payment = taxiFare * distance;
                Console.WriteLine($"\nThe approximate cost of the trip will be {payment}$. Have a safe trip!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nError: {e.Message}");
            }
        }
    }
}
