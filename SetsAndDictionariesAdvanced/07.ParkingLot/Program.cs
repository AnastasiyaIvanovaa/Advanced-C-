using System;
using System.Collections.Generic;

namespace _6.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();
                string input = Console.ReadLine();

            while (input != "END")
            {
                string[] command = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
               
                if (command[0]=="IN")
                {
                    carNumbers.Add(command[1]);
                }
                else
                {
                    carNumbers.Remove(command[1]);
                }
                input = Console.ReadLine();
            }

            if (carNumbers.Count > 0)
            {
                foreach (var carNumber in carNumbers)
                {
                    Console.WriteLine(carNumber);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
