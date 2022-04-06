using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.RawData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            Tires[] tires= new Tires[4];
            int n = int.Parse(Console.ReadLine());


            for ( int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model=data[0];
                var engine = new Engine(int.Parse(data[1]), int.Parse(data[2]));
                var cargo = new Cargo(data[4],int.Parse(data[3]));
                tires=new Tires[]
                {
                   new Tires( int.Parse(data[6]),double.Parse(data[5])),
                new Tires(int.Parse(data[8]),double.Parse(data[7])),
               new Tires(int.Parse(data[10]),double.Parse(data[9])),
                new Tires(int.Parse(data[12]), double.Parse(data[11]))
                };

                var car = new Car(model,engine,cargo,tires);
                cars.Add(car);

            }
            string filter = Console.ReadLine().ToLower();
            if (filter=="fragile")
            {
                List<Car> filtered = cars.Where(c => c.Cargo.Type == "fragile").ToList();

                foreach (var item in filtered)
                {
                    bool isPressure = true;
                    foreach (var tire in item.Tire)
                    {
                        if (tire.Pressure>1)
                        {
                            isPressure = false;
                        }
                    }
                    if (isPressure)
                    {
                        Console.WriteLine(item.Model);
                    }
                }
            }
            else if (filter== "flammable")
            {
                List<Car> filtered = cars.Where(c => c.Cargo.Type == "flammable").ToList();
                foreach (var item in filtered)
                {
                    if (item.Engine.Power>250)
                    {
                        Console.WriteLine(item.Model);
                    }
                }
            }
        }
    }
}
