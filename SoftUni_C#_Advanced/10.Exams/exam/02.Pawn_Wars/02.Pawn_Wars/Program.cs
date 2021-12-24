using System;

namespace _02.Pawn_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[8, 8];
            int whiteRow = -1;
            int whiteCol = -1;
            int blackRow = -1;
            int blackCol = -1;

            int capturedRow = -1;
            int capturedCol = -1;
            bool whiteWon = false;
            bool blackWon = false;
            bool whiteWonQueen = false;
            bool blackWonQueen = false;
            for (int row = 0; row < board.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = input[col];
                    if (board[row, col] == 'w')
                    {
                        whiteRow = row;
                        whiteCol = col;
                    }

                    if (board[row, col] == 'b')
                    {
                        blackRow = row;
                        blackCol = col;
                    }
                }
            }

            while (true)
            {

                
                if (whiteRow - 1 >= 0 && whiteCol - 1 >= 0)
                {
                    if ((board[whiteRow - 1, whiteCol - 1] == 'b'))
                    {
                        board[whiteRow, whiteCol] = '-';
                        capturedCol = whiteCol - 1;
                        capturedRow = whiteRow - 1;
                        board[capturedRow, capturedCol] = 'w';
                        whiteWon = true;
                        break;
                    }
                }
                if (whiteRow - 1 > 0 && whiteCol + 1 < 8)
                {
                    if ((board[whiteRow - 1, whiteCol + 1] == 'b'))
                    {
                        board[whiteRow, whiteCol] = '-';
                        capturedCol = whiteCol + 1;
                        capturedRow = whiteRow - 1;
                        board[capturedRow, capturedCol] = 'w';
                        whiteWon = true;
                        break;
                    }

                }


                board[whiteRow, whiteCol] = '-';
                whiteRow--;
                board[whiteRow, whiteCol] = 'w';
                if (whiteRow == 0)
                {
                    whiteWonQueen = true;
                    break;
                }
              

                if (IsValidInx(board, blackRow + 1, blackCol - 1))
                {
                    if (board[blackRow + 1, blackCol - 1] == 'w')
                    {
                        board[blackRow, blackCol] = '-';
                        capturedCol = blackCol - 1;
                        capturedRow = blackRow + 1;
                        board[capturedRow, capturedCol] = 'b';
                        blackWon = true;
                        break;
                    }
                }



                if (IsValidInx(board, blackRow + 1, blackCol + 1))
                {
                    if (board[blackRow + 1, blackCol + 1] == 'w')
                    {
                        board[blackRow, blackCol] = '-';
                        capturedCol = blackCol + 1;
                        capturedRow = blackRow + 1;
                        board[capturedRow, capturedCol] = 'b';
                        blackWon = true;
                        break;
                    }
                }

                board[blackRow, blackCol] = '-';
                blackRow++;
                board[blackRow, blackCol] = 'b';
                if (blackRow == 7)
                {
                    blackWonQueen = true;
                    break;
                }
                

                
            }

            if (whiteWonQueen)
            {
                char winRow = '1';
                if (whiteCol == 0)
                {
                    winRow = 'a';
                }
                if (whiteCol == 1)
                {
                    winRow = 'b';
                }
                if (whiteCol == 2)
                {
                    winRow = 'c';
                }
                if (whiteCol == 3)
                {
                    winRow = 'd';
                }
                if (whiteCol == 4)
                {
                    winRow = 'e';
                }
                if (whiteCol == 5)
                {
                    winRow = 'f';
                }
                if (whiteCol == 6)
                {
                    winRow = 'g';
                }
                if (whiteCol == 7)
                {
                    winRow = 'h';
                }

                Console.WriteLine($"Game over! White pawn is promoted to a queen at {winRow}8.");
            }

            if (whiteWon)
            {
                char winRow = '1';
                if (capturedCol == 0)
                {
                    winRow = 'a';
                }
                if (capturedCol == 1)
                {
                    winRow = 'b';
                }
                if (capturedCol == 2)
                {
                    winRow = 'c';
                }
                if (capturedCol == 3)
                {
                    winRow = 'd';
                }
                if (capturedCol == 4)
                {
                    winRow = 'e';
                }
                if (capturedCol == 5)
                {
                    winRow = 'f';
                }
                if (capturedCol == 6)
                {
                    winRow = 'g';
                }
                if (capturedCol == 7)
                {
                    winRow = 'h';
                }



                Console.WriteLine($"Game over! White capture on {winRow}{ 8-capturedRow}.");

            }

            if (blackWonQueen)
            {
                char winRow = '1';
                if (blackCol == 0)
                {
                    winRow = 'a';
                }
                if (blackCol == 1)
                {
                    winRow = 'b';
                }
                if (blackCol == 2)
                {
                    winRow = 'c';
                }
                if (blackCol == 3)
                {
                    winRow = 'd';
                }
                if (blackCol == 4)
                {
                    winRow = 'e';
                }
                if (blackCol == 5)
                {
                    winRow = 'f';
                }
                if (blackCol == 6)
                {
                    winRow = 'g';
                }
                if (blackCol == 7)
                {
                    winRow = 'h';
                }
                Console.WriteLine($"Game over! Black pawn is promoted to a queen at {winRow}{0}.");
            }

            if (blackWon)
            {
                char winRow = '1';
                if (capturedCol == 0)
                {
                    winRow = 'a';
                }
                if (capturedCol == 1)
                {
                    winRow = 'b';
                }
                if (capturedCol == 2)
                {
                    winRow = 'c';
                }
                if (capturedCol == 3)
                {
                    winRow = 'd';
                }
                if (capturedCol == 4)
                {
                    winRow = 'e';
                }
                if (capturedCol == 5)
                {
                    winRow = 'f';
                }
                if (capturedCol == 6)
                {
                    winRow = 'g';
                }
                if (capturedCol == 7)
                {
                    winRow = 'h';
                }
                Console.WriteLine($"Game over! Black capture on {winRow}{ 8-capturedRow}.");
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
            static bool IsValidInx(char[,] board, int row, int col)
            {
                if (row < 0 || row >= board.GetLength(0))
                {
                    return false;
                }

                if (col < 0 || col >= board.GetLength(1))
                {
                    return false;
                }

                return true;
            }
        }
    }
}
