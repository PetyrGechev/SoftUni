using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1.TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> plates = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            bool IsSuccessfull = true;
            Stack<int> orcs = null;
            bool plateDestroyed = false;
            //10 20 30 plates

            // 4 5 1
            // 10 5 5
            // 10 10 10
            int waveCounter = 0;

            for (int i = 0; i < n; i++)
            {


                waveCounter++;
                Stack<int> orcsWave = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
                while (plates.Count > 0 && orcsWave.Count > 0)
                {
                    

                    if (waveCounter == 3)
                    {
                        waveCounter = 0;
                        int additionPlate = int.Parse(Console.ReadLine());
                        plates.Enqueue(additionPlate);
                    }

                    int plate = plates.Peek();
                    int orc = orcsWave.Peek();
                    if (orc > plate)
                    {
                        orc = orcsWave.Pop();
                        orc -= plates.Dequeue();
                        orcsWave.Push(orc);

                    }

                    else if (orc == plate)
                    {
                        orcsWave.Pop();
                        plates.Dequeue();
                    }

                    else if (plate > orc)
                    {
                        Queue<int> tempQueue = new Queue<int>();
                        plate = plates.Dequeue();
                        orc = orcsWave.Pop();
                        plate -= orc;
                        tempQueue.Enqueue(plate);
                        for (int j = 0; j < plates.Count; j++)
                        {
                            tempQueue.Enqueue(plates.Dequeue());
                            j--;
                        }

                        plates = tempQueue;
                    }

                    if (plates.Count == 0)
                    {
                        orcs = orcsWave;
                        IsSuccessfull = false;
                        break;

                    }

                }

            }

            if (IsSuccessfull)
            {
                Console.WriteLine($"The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
            else
            {
                Console.WriteLine($"The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", orcs)}");
            }


        }
    }
}
