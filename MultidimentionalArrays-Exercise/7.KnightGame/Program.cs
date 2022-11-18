using System;

namespace _7.KnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] chess = new string[n, n];
            for (int i = 0; i < chess.GetLength(0); i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < chess.GetLength(1); j++)
                {
                    chess[i, j] = input[j].ToString();
                }
            }

            int count = 0;

            while (true)
            {
                int row = 0;
                int col = 0;
                int maxAttack = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        int attack = 0;
                        if (chess[i, j] == "K")
                        {
                            if (i - 1 >= 0 && j - 2 > 0 && chess[i - 1, j - 2] == "K")
                            {
                                attack++;
                            }
                            if (i - 2 >= 0 && j - 1 >= 0 && chess[i - 2, j - 1] == "K")
                            {
                                attack++;
                            }
                            if (i - 2 >= 0 && j + 1 < n && chess[i - 2, j + 1] == "K")
                            {
                                attack++;
                            }
                            if (i - 1 >= 0 && j + 2 < n && chess[i - 1, j + 2] == "K")
                            {
                                attack++;
                            }
                            if (i + 1 < n && j + 2 < n && chess[i + 1, j + 2] == "K")
                            {
                                attack++;
                            }
                            if (i + 2 < n && j + 1 < n && chess[i + 2, j + 1] == "K")
                            {
                                attack++;
                            }
                            if (i + 2 < n && j - 1 >= 0 && chess[i + 2, j - 1] == "K")
                            {
                                attack++;
                            }
                            if (i + 1 < n && j - 2 >= 0 && chess[i + 1, j - 2] == "K")
                            {
                                attack++;
                            }
                        }
                        if (attack > maxAttack)
                        {
                            maxAttack = attack;
                            row = i;
                            col = j;
                        }
                    }
                }
                if (maxAttack != 0)
                {
                    chess[row, col] = "0";
                    count++;
                }
                else
                {
                    break;
                }
            }
                Console.WriteLine(count);
        }
    }
}
