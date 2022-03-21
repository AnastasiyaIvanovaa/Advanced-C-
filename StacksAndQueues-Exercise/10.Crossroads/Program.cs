using System;
using System.Collections.Generic;

namespace _10.Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int green = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string command = Console.ReadLine();
            int carsCount = 0;

            while (command!="END")
            {
                int time = green;
                if (command == "green")
                {
                    while (cars.Count > 0 && time > 0)
                    {
                        string current = cars.Dequeue();
                        int count = current.Length;

                        if (time - count < 0 && time - count + freeWindow < 0)
                        {
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{current} was hit at {current[time + freeWindow]}.");
                            return;
                        }
                        else
                        {
                            time -= count;
                            carsCount++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carsCount} total cars passed the crossroads.");
        }
    }
}
