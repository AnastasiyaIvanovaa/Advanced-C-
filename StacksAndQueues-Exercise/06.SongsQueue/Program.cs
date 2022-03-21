using System;
using System.Collections.Generic;

namespace _06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] songsInput = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            Queue<string> songs = new Queue<string>(songsInput);

            while (songs.Count>0)
            {
                string command = Console.ReadLine();

                if (command.Contains( "Play"))
                {
                    songs.Dequeue();
                }
                else if (command.Contains( "Add"))
                {
                    string nameOfTheSong = command.Substring(4);
                    if (!songs.Contains(nameOfTheSong))
                    {
                        songs.Enqueue(nameOfTheSong);
                    }
                    else
                    {
                        Console.WriteLine($"{nameOfTheSong} is already contained!");
                    }
                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ",songs));
                }

            }
            Console.WriteLine("No more songs!");
                    }
    }
}
