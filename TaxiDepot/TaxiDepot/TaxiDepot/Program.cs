using System;
using System.Collections.Generic;


namespace TaxiDepot
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a number of seats you are needed from the following:  ");
            Parameters.ShowAvailableSeats(Initialization.GetAutoList());

            IList<Vehicle> seatsList;
            do
            {   Console.Write("\n\nYour value:  ");
                int capacity = int.Parse(Console.ReadLine());
                seatsList = Parameters.GetExistingParameters(Initialization.GetAutoList(), capacity);
            } while (seatsList.Count == 0);

            Console.WriteLine("\nPlease choose model of the vehicle from the following:");
            Parameters.ShowAvailableModel(seatsList);

            IList<Vehicle> modelList;
            do
            {   Console.Write("\nYour choice:  ");
                string model = Console.ReadLine();
                modelList = Parameters.GetExistingParameters(seatsList, model);
            } while (modelList.Count == 0);

            double fare;
            IList<Vehicle> fareList;
            if (modelList.Count >= 2)
            {
                Console.Write("\nPlease choose the taxi fare from the following:  ");
                Parameters.ShowAvailableFare(modelList);

                do
                {   Console.Write("\n\nEnter taxi rate:  ");
                    fare = double.Parse(Console.ReadLine());
                    fareList = Parameters.GetExistingParameters(modelList, fare);
                } while (fareList.Count == 0);

                Console.WriteLine($"\nYou have chosen {fareList[0].Model} with taxi fare {fareList[0].Fare}.");
            }
            else
            {
                fare = modelList[0].Fare;
                Console.WriteLine($"\nYou have chosen {modelList[0].Model} with taxi fare {modelList[0].Fare}.");
            }

            Console.Write("\nPlease enter the distance you need (NOTE: the available distance ranges from 1 km to 50 km).\n");
            double distance, payment;
            do
            {   Console.Write("\nYour value:  ");
                distance = double.Parse(Console.ReadLine());
                payment = Parameters.CountDistance(distance, fare);
            } while (TaxiDepot.MinAvailableDistance > distance || distance > TaxiDepot.MaxAvailableDistance);

            Console.WriteLine($"\nThe approximate cost of the trip will be {payment}$. Have a safe trip!");
        }
    }
}
