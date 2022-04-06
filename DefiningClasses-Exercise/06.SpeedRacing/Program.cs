using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SpeedRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car();
                car.Model = carData[0];
                car.FuelAmount = double.Parse(carData[1]);
                car.FuelConsumptionPerKilometer = double.Parse(carData[2]);
                car.TravelledDistance = 0;

                cars.Add(car);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] inputData = command.Split();
                string model = inputData[1];
                Car currentCar = cars.Where(x=> x.Model == model).FirstOrDefault();
                currentCar.CanMove(currentCar.FuelConsumptionPerKilometer, double.Parse(inputData[2]), currentCar.FuelAmount, currentCar.Model, currentCar);

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
