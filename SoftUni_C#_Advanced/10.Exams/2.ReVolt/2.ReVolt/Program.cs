using System;

namespace _2.ReVolt
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixSize, matrixSize];
            int playerRow = -1;
            int playerCol = -1;
            bool playerWon = false;
            for (int row = 0; row < matrixSize; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = input[col];
                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                if (command == "up")
                {
                    matrix[playerRow, playerCol] = '-';
                    playerRow = playerRow - 1;
                    if (playerRow < 0)
                    {
                        playerRow = matrix.GetLength(0) - 1;
                    }
                    if (matrix[playerRow, playerCol] == 'F')
                    {
                        matrix[playerRow, playerCol] = 'f';
                        playerWon = true;
                        break;
                    }
                    else if (matrix[playerRow, playerCol] == 'B')
                    {
                        while (matrix[playerRow, playerCol] == 'B')
                        {
                            playerRow = playerRow - 1;
                            if (playerRow < 0)
                            {
                                playerRow = matrix.GetLength(0) - 1;
                            }
                            if (matrix[playerRow, playerCol] == 'F')
                            {
                                matrix[playerRow, playerCol] = 'f';
                                playerWon = true;
                                break;
                            }
                        }
                        if (playerWon)
                        {
                            break;
                        }
                    }

                    else if (matrix[playerRow, playerCol] == 'T')
                    {
                        playerRow = playerRow + 1;

                    }
                    matrix[playerRow, playerCol] = 'f';
                   
                }
                else if (command == "down")
                {
                    matrix[playerRow, playerCol] = '-';
                    playerRow = playerRow + 1;
                    if (playerRow >= matrix.GetLength(0))
                    {
                        playerRow = 0;
                    }
                    if (matrix[playerRow, playerCol] == 'F')
                    {
                        matrix[playerRow, playerCol] = 'f';
                        playerWon = true;
                        break;
                    }
                    else if (matrix[playerRow, playerCol] == 'B')
                    {
                        while (matrix[playerRow, playerCol] == 'B')
                        {
                            playerRow = playerRow + 1;
                            if (playerRow >= matrix.GetLength(0))
                            {
                                playerRow = 0;
                            }
                            if (matrix[playerRow, playerCol] == 'F')
                            {
                                matrix[playerRow, playerCol] = 'f';
                                playerWon = true;
                                break;
                            }

                        }
                        if (playerWon)
                        {
                            break;
                        }
                    }
                    else if (matrix[playerRow, playerCol] == 'T')
                    {
                        playerRow = playerRow - 1;

                    }

                    matrix[playerRow, playerCol] = 'f';
                   

                }
                else if (command == "right")
                {
                    matrix[playerRow, playerCol] = '-';
                    playerCol = playerCol + 1;
                    if (playerCol >= matrix.GetLength(0))
                    {
                        playerCol = 0;
                    }
                    if (matrix[playerRow, playerCol] == 'F')
                    {
                        matrix[playerRow, playerCol] = 'f';
                        playerWon = true;
                        break;
                    }
                    else if (matrix[playerRow, playerCol] == 'B')
                    {
                        while (matrix[playerRow, playerCol] == 'B')
                        {
                            playerCol = playerCol + 1;
                            if (playerCol >= matrix.GetLength(0))
                            {
                                playerCol = 0;
                            }
                            if (matrix[playerRow, playerCol] == 'F')
                            {
                                matrix[playerRow, playerCol] = 'f';
                                playerWon = true;
                                break;
                            }

                        }
                        if (playerWon)
                        {
                            break;
                        }
                    }
                    else if (matrix[playerRow, playerCol] == 'T')
                    {
                        playerCol = playerCol - 1;

                    }

                    matrix[playerRow, playerCol] = 'f';
                    

                }
                else if (command == "left")
                {
                    matrix[playerRow, playerCol] = '-';
                    playerCol = playerCol - 1;
                    if (playerCol < 0)
                    {
                        playerCol = matrix.GetLength(1) - 1;
                    }
                    if (matrix[playerRow, playerCol] == 'F')
                    {
                        matrix[playerRow, playerCol] = 'f';
                        playerWon = true;
                        break;
                    }
                    else if (matrix[playerRow, playerCol] == 'B')
                    {
                        while (matrix[playerRow, playerCol] == 'B')
                        {
                            playerCol = playerCol - 1;
                            if (playerCol < 0)
                            {
                                playerCol = matrix.GetLength(1) - 1;
                            }
                            if (matrix[playerRow, playerCol] == 'F')
                            {
                                matrix[playerRow, playerCol] = 'f';
                                playerWon = true;
                                break;
                            }

                        }
                        if (playerWon)
                        {
                            break;
                        }
                    }
                    else if (matrix[playerRow, playerCol] == 'T')
                    {
                        playerCol = playerCol + 1;

                    }

                    matrix[playerRow, playerCol] = 'f';
                   

                }
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

            if (playerWon)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }

            Print(matrix);
        }
    }
}
