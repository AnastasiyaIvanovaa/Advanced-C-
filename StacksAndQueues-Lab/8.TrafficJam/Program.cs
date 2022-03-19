using System;
using System.Collections.Generic;

namespace _8.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int countOfCars = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int counter = 0;
            string command = Console.ReadLine();

            while (command!="end")
            {
                if (command=="green")
                {
                    if (cars.Count<=countOfCars)
                    {
                        counter += cars.Count;
                        while (cars.Count>0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < countOfCars; i++)
                        {
                            counter++;
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
