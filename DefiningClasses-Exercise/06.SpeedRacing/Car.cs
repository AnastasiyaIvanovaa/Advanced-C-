using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.SpeedRacing
{
    public class Car
    {
        private string model;

        public Car()
        {
            this.Members = new List<Car>();
        }
        public List<Car> Members { get; set; }
        public string Model
        {
            get => Model = model;
            set => model = value;
        }

        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car CanMove(double fuelConsumptionPerKilometer, double km, double fuelAmount, string model, Car car)
        {
            double amountNeeded = car.FuelConsumptionPerKilometer * km;
            if (amountNeeded<=car.FuelAmount)
            {
                car.FuelAmount -= amountNeeded;
                car.TravelledDistance += km;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

            return car;
        }
    }
}