using System;
using System.Data;
using System.Reflection;

namespace _2.Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] field = new char[n][];
            int myPlayerTokens = 0;
            int OppositePlayerTokens = 0;
            for (int row = 0; row < n; row++)
            {
                string[] fieldRowArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string fieldRowLikeString = string.Join("", fieldRowArr);
                char[] fieldInput = fieldRowLikeString.ToCharArray();
                field[row] = new char[fieldRowLikeString.Length];
                for (int col = 0; col < fieldRowLikeString.Length; col++)
                {
                    field[row][col] = fieldInput[col];
                }
            }
            



            string command = Console.ReadLine();
            while (command != "Gong")
            {
                string[] commandInfo = command.Split();
                if (commandInfo[0] == "Find")
                {
                    int row = int.Parse(commandInfo[1]);
                    int col = int.Parse(commandInfo[2]);
                    if (IsValidInx(field, row, col))
                    {
                        if (field[row][col] == 'T')
                        {
                            myPlayerTokens++;
                            field[row][col] = '-';
                        }


                    }



                }
                else
                {
                    int row = int.Parse(commandInfo[1]);
                    int col = int.Parse(commandInfo[2]);
                    string direction = commandInfo[3];
                    if (IsValidInx(field, row, col))
                    {



                        if (field[row][col] == 'T')
                        {
                            OppositePlayerTokens++;
                            field[row][col] = '-';
                        }

                        if (direction == "up")
                        {
                            for (int i = 1; i < 4; i++)
                            {
                                int theRow = row - i;
                                if (IsValidInx(field, theRow , col))
                                {
                                    if (field[theRow][col] == 'T')
                                    {
                                        OppositePlayerTokens++;
                                        field[theRow][col] = '-';
                                    }
                                }
                            }
                        }
                        else if (direction == "down")
                        {
                            for (int i = 1; i < 4; i++)
                            {
                                int theRow = row + i;
                                if (IsValidInx(field, theRow, col))
                                {
                                    if (field[theRow][col] == 'T')
                                    {
                                        OppositePlayerTokens++;
                                        field[theRow][col] = '-';
                                    }
                                }
                            }
                        }
                        else if (direction == "left")
                        {
                            for (int i = 1; i < 4; i++)
                            {
                                int theCol = col - i;
                                if (IsValidInx(field, row, theCol))
                                {
                                    
                                    if (field[row][theCol] == 'T')
                                    {
                                        OppositePlayerTokens++;
                                        field[row][theCol] = '-';
                                    }
                                }
                            }
                        }
                        else if (direction == "right")
                        {
                            for (int i = 1; i < 4; i++)
                            {
                                int theCol = col + i;
                                if (IsValidInx(field, row, theCol))
                                {
                                    if (field[row][theCol] == 'T')
                                    {
                                        OppositePlayerTokens++;
                                        field[row][theCol] = '-';
                                    }
                                }
                            }
                        }
                    }
                }


                command = Console.ReadLine();
            }

            Console.WriteLine($"Collected tokens: {myPlayerTokens}");
            Console.WriteLine($"Opponent's tokens: {OppositePlayerTokens}");
            Print(field);

            static void Print(char[][] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {

                    // T--TT-T
                    //T - - T T - T
                    Console.WriteLine(String.Join(" ", matrix[i]));
                }
            }

        }

        static bool IsValidInx(char[][] field, int row, int col)
        {
            if (row < 0 || row >= field.Length)
            {
                return false;
            }

            if (col < 0 || col >= field[row].Length)
            {
                return false;
            }

            return true;
        }
    }
}
