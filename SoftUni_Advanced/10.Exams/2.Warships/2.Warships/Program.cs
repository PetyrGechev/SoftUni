using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            List<string> firstPlayer = new List<string>();
            List<string> secondPlayer = new List<string>();
            string[] cordinates = Console.ReadLine().Split(",",StringSplitOptions.RemoveEmptyEntries);
            int firstPlayerships = 0;
            int secondPlayerships = 0;
            bool firstPlayerTurn = true;
            for (int i = 0; i < cordinates.Length; i++)
            {
                if (i % 2 == 0)
                {
                    firstPlayer.Add(cordinates[i]);
                }
                else
                {
                    secondPlayer.Add(cordinates[i]);
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split();
                string inputTest = string.Join("", input);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputTest[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == '<')
                    {
                        firstPlayerships++;
                    }
                    else if (matrix[row, col] == '>')
                    {
                        secondPlayerships++;
                    }
                }
            }
            int totalShips = firstPlayerships + secondPlayerships;
            int number = firstPlayer.Count + secondPlayer.Count;
            for (int i = 0; i < number; i++)
            {
                if (firstPlayerTurn == true)
                {
                    if (firstPlayer.Count > 0)
                    {
                        string[] cordinatesFirstPlayer = firstPlayer[0].Split(" ",StringSplitOptions.RemoveEmptyEntries);
                        int row = int.Parse(cordinatesFirstPlayer[0]);
                        int col = int.Parse(cordinatesFirstPlayer[1]);
                        firstPlayer.RemoveAt(0);
                        if (!IsValid(matrix, row, col))
                        {
                            firstPlayerTurn = false;
                            continue;
                        }
                        if (matrix[row, col] == '>')
                        {
                            matrix[row, col] = 'X';
                            secondPlayerships--;
                        }
                        else if (matrix[row, col] == '#' && IsValid(matrix, row, col))
                        {
                            if (IsValid(matrix, row - 1, col - 1))
                            {
                                if (matrix[row - 1, col - 1] == '>')
                                {
                                    secondPlayerships--;
                                }
                                if (matrix[row - 1, col - 1] == '<')
                                {
                                    firstPlayerships--;
                                }
                                matrix[row - 1, col - 1] = 'X';
                            }
                            if (IsValid(matrix, row - 1, col))
                            {
                                if (matrix[row - 1, col] == '>')
                                {
                                    secondPlayerships--;
                                }
                                if (matrix[row - 1, col] == '<')
                                {
                                    firstPlayerships--;
                                }
                                matrix[row - 1, col] = 'X';
                            }
                            if (IsValid(matrix, row - 1, col + 1))
                            {
                                if (matrix[row - 1, col + 1] == '>')
                                {
                                    secondPlayerships--;
                                }
                                if (matrix[row - 1, col + 1] == '<')
                                {
                                    firstPlayerships--;
                                }
                                matrix[row - 1, col + 1] = 'X';
                            }
                            if (IsValid(matrix, row, col - 1))
                            {
                                if (matrix[row, col - 1] == '>')
                                {
                                    secondPlayerships--;
                                }
                                if (matrix[row, col - 1] == '<')
                                {
                                    firstPlayerships--;
                                }
                                matrix[row, col - 1] = 'X';
                            }
                            if (IsValid(matrix, row, col))
                            {
                                if (matrix[row, col] == '>')
                                {
                                    secondPlayerships--;
                                }
                                if (matrix[row, col] == '<')
                                {
                                    firstPlayerships--;
                                }

                                matrix[row, col] = 'X';
                            }
                            if (IsValid(matrix, row, col + 1))
                            {
                                if (matrix[row, col + 1] == '>')
                                {
                                    secondPlayerships--;
                                }
                                if (matrix[row, col + 1] == '<')
                                {
                                    firstPlayerships--;
                                }
                                matrix[row, col + 1] = 'X';
                            }
                            if (IsValid(matrix, row + 1, col - 1))
                            {
                                if (matrix[row + 1, col - 1] == '>')
                                {
                                    secondPlayerships--;
                                }
                                if (matrix[row + 1, col - 1] == '<')
                                {
                                    firstPlayerships--;
                                }
                                matrix[row + 1, col - 1] = 'X';
                            }
                            if (IsValid(matrix, row + 1, col))
                            {
                                if (matrix[row + 1, col] == '>')
                                {
                                    secondPlayerships--;
                                }
                                if (matrix[row + 1, col] == '<')
                                {
                                    firstPlayerships--;
                                }
                                matrix[row + 1, col] = 'X';
                            }
                            if (IsValid(matrix, row + 1, col + 1))
                            {
                                if (matrix[row + 1, col + 1] == '>')
                                {
                                    secondPlayerships--;
                                }
                                if (matrix[row + 1, col + 1] == '<')
                                {
                                    firstPlayerships--;
                                }
                                matrix[row + 1, col + 1] = 'X';
                            }
                        }
                        if (secondPlayerships < 1)
                        {
                            break;

                        }
                    }
                    firstPlayerTurn = false;
                }
                else
                {
                    if (secondPlayer.Count > 0)
                    {
                        string[] cordinatesSecondPlayer = secondPlayer[0].Split(" ",StringSplitOptions.RemoveEmptyEntries);
                        int row = int.Parse(cordinatesSecondPlayer[0]);
                        int col = int.Parse(cordinatesSecondPlayer[1]);
                        secondPlayer.RemoveAt(0);
                        if (!IsValid(matrix, row, col))
                        {
                            firstPlayerTurn = true;
                            continue;
                        }
                        if (matrix[row, col] == '<')
                        {
                            matrix[row, col] = 'X';
                            firstPlayerships--;
                        }
                        else if (matrix[row, col] == '#' && IsValid(matrix, row, col))
                        {
                            if (IsValid(matrix, row - 1, col - 1))
                            {
                                if (matrix[row - 1, col - 1] == '<')
                                {
                                    firstPlayerships--;
                                }
                                if (matrix[row - 1, col - 1] == '>')
                                {
                                    secondPlayerships--;
                                }
                                matrix[row - 1, col - 1] = 'X';

                            }
                            if (IsValid(matrix, row - 1, col))
                            {
                                if (matrix[row - 1, col] == '<')
                                {
                                    firstPlayerships--;
                                }
                                if (matrix[row - 1, col] == '>')
                                {
                                    secondPlayerships--;
                                }
                                matrix[row - 1, col] = 'X';

                            }
                            if (IsValid(matrix, row - 1, col + 1))
                            {
                                if (matrix[row - 1, col + 1] == '<')
                                {
                                    firstPlayerships--;
                                }
                                if (matrix[row - 1, col + 1] == '>')
                                {
                                    secondPlayerships--;
                                }
                                matrix[row - 1, col + 1] = 'X';
                            }
                            if (IsValid(matrix, row, col - 1))
                            {
                                if (matrix[row, col - 1] == '<')
                                {
                                    firstPlayerships--;
                                }
                                if (matrix[row, col - 1] == '>')
                                {
                                    secondPlayerships--;
                                }
                                matrix[row, col - 1] = 'X';
                            }
                            if (IsValid(matrix, row, col))
                            {
                                if (matrix[row, col] == '<')
                                {
                                    firstPlayerships--;
                                }
                                if (matrix[row, col] == '>')
                                {
                                    secondPlayerships--;
                                }
                                matrix[row, col] = 'X';
                            }
                            if (IsValid(matrix, row + 1, col + 1))
                            {
                                if (matrix[row + 1, col + 1] == '<')
                                {
                                    firstPlayerships--;
                                }
                                if (matrix[row + 1, col + 1] == '>')
                                {
                                    secondPlayerships--;
                                }
                                matrix[row + 1, col + 1] = 'X';
                            }
                            if (IsValid(matrix, row + 1, col - 1))
                            {
                                if (matrix[row + 1, col - 1] == '<')
                                {
                                    firstPlayerships--;
                                }
                                if (matrix[row + 1, col - 1] == '>')
                                {
                                    secondPlayerships--;
                                }
                                matrix[row + 1, col - 1] = 'X';
                            }
                            if (IsValid(matrix, row + 1, col))
                            {
                                if (matrix[row + 1, col] == '<')
                                {
                                    firstPlayerships--;
                                }
                                if (matrix[row + 1, col] == '>')
                                {
                                    secondPlayerships--;
                                }
                                matrix[row + 1, col] = 'X';
                            }
                            if (IsValid(matrix, row + 1, col + 1))
                            {
                                if (matrix[row + 1, col + 1] == '<')
                                {
                                    firstPlayerships--;
                                }
                                if (matrix[row + 1, col + 1] == '>')
                                {
                                    secondPlayerships--;
                                }
                                matrix[row + 1, col + 1] = 'X';
                            }


                        }
                        if (firstPlayerships < 1)
                        {
                            break;

                        }


                    }
                    firstPlayerTurn = true;

                }

            }
            if (secondPlayerships < 1)
            {
                Console.WriteLine($"Player One has won the game! {totalShips - firstPlayerships - secondPlayerships} ships have been sunk in the battle.");
            }
            else if (firstPlayerships < 1)
            {
                Console.WriteLine($"Player Two has won the game! {totalShips - firstPlayerships - secondPlayerships} ships have been sunk in the battle.");
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {firstPlayerships} ships left. Player Two has {secondPlayerships} ships left.");
            }

            static void Print(char[,] matrix)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {

                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(matrix[row, col]);
                    }

                    Console.WriteLine();
                }

            }
            static bool IsValid(char[,] matrix, int row, int col)
            {
                if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
                {
                    return false;
                }
                return true;
            }
        }
    }
}
