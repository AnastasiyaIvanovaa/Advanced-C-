using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] amountDistance = Console.ReadLine().Split().Select(int.Parse).ToArray();
                pumps.Enqueue(amountDistance);
            }

            bool isSuccessful = true;
            int petrol = 0;
            int number = 0;

            for (int i = 0; i < n; i++)
            {
                isSuccessful = true;
                petrol = 0;
                for (int j = 0; j < pumps.Count; j++)
                {
                    int[] currentPump = pumps.Dequeue();
                    pumps.Enqueue(currentPump);

                    petrol += currentPump[0] - currentPump[1];
                    if (petrol < 0)
                    {
                        isSuccessful = false;
                        break;
                    }
                }
                if (isSuccessful)
                {
                    number = i;
                    break;
                }
            }
            Console.WriteLine(number);
        }
    }
}
