using System;
using System.IO;
using System.Linq;

namespace _1.EvenLines
{
    public class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                int counter = 0;
                string line = reader.ReadLine();
                while (line!=null)
                {
                    string currentLine = string.Empty;
                    string[] vs = line.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                    string[] reversed = vs.Reverse().ToArray();
                    if (counter%2==0)
                    {
                        for (int i = 0; i < reversed.Length; i++)
                        {
                            for (int j = 0; j < reversed[i].Length; j++)
                            {
                                string word = reversed[i];
                                char symbol = word[j];
                                if (symbol == '-' || symbol == ',' || symbol == '!' || symbol == '?' || symbol=='.')
                                {
                                    symbol = '@';
                                }
                                currentLine += symbol;
                            }
                            currentLine += " ";
                            
                        }
                        using (StreamWriter writer = new StreamWriter("../../../output.txt", true))
                        {
                            writer.WriteLine(currentLine);
                        }
                        Console.WriteLine(currentLine);
                    }
                    counter++;
                    line = reader.ReadLine();
                }
            }
            //Write a program that reads a text file and prints on the console its even lines. Line numbers start from 0. Use StreamReader. Before you print the result replace {"-", ",", ".", "!", "?"} with "@" and reverse the order of the words.
        }
    }
}
