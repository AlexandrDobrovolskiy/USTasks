using System;
using System.Collections.Generic;
using System.Dynamic;
using static System.Console;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = new int[10,5]
            { 
                {0,1,0,0,0 },
                {1,1,1,0,1 },
                {0,0,0,0,0 },
                {1,1,1,0,0 },
                {0,0,0,1,0 },
                {0,1,1,1,1 },
                {0,0,0,0,0 },
                {1,0,1,0,0 },
                {0,0,1,0,0 },
                {1,0,1,0,0 }
            };

            List<int[]> indexes = new List<int[]>();



            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (grid[i,j] == 1)
                    {
                        indexes.Add(new int[2]{i,j});
                    }
                }
            }

            

            for (int i = 0; i < indexes.Count; i++)
            {
                for (int j = 1; j < indexes.Count; j++)
                {
                    if (Math.Abs(indexes[i][0] - indexes[j][0]) == 1 || Math.Abs(indexes[i][1] - indexes[j][1]) == 1)
                    {
                        indexes.RemoveAt(i);
                    }
                }
            }
            int count = indexes.Count;

            WriteLine(count);

            ReadLine();
        }
    }
}
