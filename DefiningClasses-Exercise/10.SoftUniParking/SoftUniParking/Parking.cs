using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new List<Car>();
        }
        public int Count => this.cars.Count;
        public string AddCar(Car Car)
        {
            if (this.cars.Any(c=>c.RegistrationNumber==Car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            if (this.capacity==this.cars.Count)
            {
                return "Parking is full!";
            }
            this.cars.Add(Car);
            return $"Successfully added new car {Car.Make} {Car.RegistrationNumber}";
        }

        public string RemoveCar(string registrationNumber)
        {
            Car car = cars.FirstOrDefault(c=>c.RegistrationNumber == registrationNumber);
            if (car==null)
            {
            return $"Car with that registration number, doesn't exist!";
            }
                this.cars.Remove(car);
                return $"Successfully removed {registrationNumber}";
        }

        public Car GetCar(string registrationNumber)
        {
            Car car = this.cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);

                return car;
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            this.cars = this.cars.Where(c => !registrationNumbers.Contains(c.RegistrationNumber)).ToList();
        }
    }
}
