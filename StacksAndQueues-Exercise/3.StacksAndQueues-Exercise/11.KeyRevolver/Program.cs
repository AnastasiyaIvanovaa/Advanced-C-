using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceOfTheBullet = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            int[] gunBarellInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> gunBarell = new Stack<int>(gunBarellInput);
            int[] locksInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> locks = new Queue<int>(locksInput);
            int intelligence = int.Parse(Console.ReadLine());
            int shootsCounter = 0;

            while (locks.Count>0 && gunBarell.Count>0)
            {
                int bullet = gunBarell.Pop();
                int lockToShoot = locks.Peek();
                if (lockToShoot>=bullet)
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                shootsCounter++;
                if (shootsCounter==size && gunBarell.Count>0)
                {
                    Console.WriteLine("Reloading!");
                    shootsCounter = 0;
                }  
            }
            if (gunBarell.Count==0 && locks.Count>0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                Console.WriteLine($"{gunBarell.Count} bullets left. Earned ${intelligence - priceOfTheBullet*(gunBarellInput.Length-gunBarell.Count)}");
            }
        }
    }
}
