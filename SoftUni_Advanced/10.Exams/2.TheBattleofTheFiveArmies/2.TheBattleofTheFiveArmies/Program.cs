using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _2.TheBattleofTheFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            int armor = int.Parse(Console.ReadLine());
            int numberOfRows = int.Parse(Console.ReadLine());
            char[][] matrix = new char[numberOfRows][];
            int armyRow = -1;
            int armyCol = -1;   
           

            for (int row = 0; row < numberOfRows; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                matrix[row] = input;

            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'A')
                    {
                        armyRow = row;
                        armyCol = col;
                    }
                }
            }
            while (true)
            {
                if (armor <= 0)
                {

                    matrix[armyRow][armyCol] = 'X';

                    Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");
                    PrintMatrix(matrix);
                    break;


                }
                //up 3 0
                string[] input = Console.ReadLine().Split();
                string direction = input[0];
                int OrcRow = int.Parse(input[1]);
                int OrcCol = int.Parse(input[2]);
                matrix[OrcRow][OrcCol] = 'O';
                matrix[armyRow][armyCol] = '-';
                if (direction == "up" && IsInsideMatrix(matrix, armyRow - 1, armyCol))
                {

                    armyRow = armyRow - 1;


                }
                else if (direction == "down" && IsInsideMatrix(matrix, armyRow + 1, armyCol))
                {
                    armyRow = armyRow + 1;

                }
                else if (direction == "right" && IsInsideMatrix(matrix, armyRow, armyCol + 1))
                {
                    armyCol = armyCol + 1;

                }
                else if (direction == "left" && IsInsideMatrix(matrix, armyRow, armyCol - 1))
                {
                    armyCol = armyCol - 1;
                }
                armor -= 1;


                if (matrix[armyRow][armyCol] == 'O')
                {
                    armor -= 2;
                    if (armor <= 0)
                    {

                        matrix[armyRow][armyCol] = 'X';
                       
                        Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");
                        PrintMatrix(matrix);
                        break;


                    }

                }
                else if (matrix[armyRow][armyCol] == 'M')
                {
                    Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
                    matrix[armyRow][armyCol] = '-';
                    PrintMatrix(matrix);

                    break;
                }
                matrix[armyRow][armyCol] = 'A';
                PrintMatrix(matrix);
            }

        }

        private static bool IsInsideMatrix(char[][] matrix, int armyRow, int armyCol)
        {
            if (armyRow < 0 || armyRow >= matrix.Length || armyCol < 0 || armyCol >= matrix[armyRow].Length)
            {
                return false;
            }

            return true;
        }

        public static void PrintMatrix(char[][] matrix)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var row in matrix)
            {
                string output = string.Join("", row);
                sb.AppendLine(output);
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
