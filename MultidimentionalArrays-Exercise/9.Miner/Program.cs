using System;

namespace _9.Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            string[,] field = new string[fieldSize, fieldSize];
            bool isFinished = true;
            int coalCounter = 0;
            int foundedCoal = 0;
            int row = 0;
            int col = 0;
            string[] moves = Console.ReadLine().Split();

            for (int i = 0; i < fieldSize; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < fieldSize; j++)
                {
                    field[i, j] = input[j];
                    if (input[j]=="c")
                    {
                        coalCounter++;
                    }
                    if (input[j]=="s")
                    {
                        row = i;
                        col = j;
                    }
                }
            }
            
            for (int i = 0; i < moves.Length; i++)
            {
                string move = moves[i];
                if (move=="left")
                {
                    if (col-1>=0)
                    {
                        col -= 1;
                        if (field[row,col]=="c")
                        {
                            foundedCoal++;
                            field[row, col] = "*";
                            if (foundedCoal==coalCounter)
                            {
                                Console.WriteLine($"You collected all coals! ({row}, {col})");
                                isFinished = false;
                                break;
                            }
                        }
                        else if (field[row,col]=="e")
                        {
                            Console.WriteLine($"Game over! ({row}, {col})");
                            isFinished = false;
                            break;
                        }
                    }
                }
                else if (move=="right")
                {
                    if (col+1<fieldSize)
                    {
                        col += 1;
                        if (field[row, col] == "c")
                        {
                            foundedCoal++;
                            field[row, col] = "*";
                            if (foundedCoal == coalCounter)
                            {
                                Console.WriteLine($"You collected all coals! ({row}, {col})");
                                isFinished = false;
                                break;
                            }
                        }
                        else if (field[row, col] == "e")
                        {
                            Console.WriteLine($"Game over! ({row}, {col})");
                            isFinished = false;
                            break;
                        }
                    }
                }
                else if (move=="up")
                {
                    if (row-1>=0)
                    {
                        row -= 1;
                        if (field[row, col] == "c")
                        {
                            foundedCoal++;
                            field[row, col] = "*";
                            if (foundedCoal == coalCounter)
                            {
                                Console.WriteLine($"You collected all coals! ({row}, {col})");
                                isFinished = false;
                                break;
                            }
                        }
                        else if (field[row, col] == "e")
                        {
                            Console.WriteLine($"Game over! ({row}, {col})");
                            isFinished = false;
                            break;
                        }
                    }
                }
                else if (move=="down")
                {
                    if (row+1<fieldSize)
                    {
                        row += 1;
                        if (field[row, col] == "c")
                        {
                            foundedCoal++;
                            field[row, col] = "*";
                            if (foundedCoal == coalCounter)
                            {
                                Console.WriteLine($"You collected all coals! ({row}, {col})");
                                isFinished = false;
                                break;
                            }
                        }
                        else if (field[row, col] == "e")
                        {
                            Console.WriteLine($"Game over! ({row}, {col})");
                            isFinished = false;
                            break;
                        }
                    }
                }
            }

            if (isFinished)
            {
                Console.WriteLine($"{coalCounter-foundedCoal} coals left. ({row}, {col})");
            }
        }
    }
}
