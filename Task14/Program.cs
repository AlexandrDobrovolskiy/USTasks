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
            WriteLine("Enter n and m (sizes of the image, separate by space): ");
            String[] inputs = ReadLine().Split();

            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);
            
            int[,] grid = new int[n,m];

            WriteLine("Enter image (separate pixeles by space, rowws - by enter): ");
            for (int i = 0; i < n; i++)
            {
                string[] row = ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    grid[i,j] = Int32.Parse(row[j]);
                }
            }

            List<int[]> indexes = new List<int[]>();




            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
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
                    if (Math.Abs(indexes[i][0] - indexes[j][0]) == 0 || Math.Abs(indexes[i][1] - indexes[j][1]) == 0)
                    {
                        indexes.RemoveAt(i);
                    }
                }
            }

            int count = indexes.Count + 1;

            WriteLine(count);

            ReadLine();
        }
    }
}
