using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using static System.Console;

namespace Task14
{


    class Program
    {
        public static void Labeling(int[,] image, int H, int W)
        {
            int L = 1;
            for (int x =0; x < H; x++)
            {
                for (int y = 0; y < W; y++)
                {
                    if (image[x, y] != 0)
                    {
                        image[x, y] = L;
                        if (image[x + 1, y] == 1) image[x + 1, y] = L;
                        if (image[x, y + 1] == 1) image[x, y + 1] = L;
                    }
                    else L++;
                }
            }

        }

        public static void Fill(int[] image, int lables, int x, int y, int L)
        {
            
        }

        static void Main(string[] args)
        {
            WriteLine("Enter n and m (sizes of the image, separate by space): ");
            String[] inputs = ReadLine().Split();

            int n = int.Parse(inputs[0]) + 1;
            int m = int.Parse(inputs[1]) + 1;

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

            Labeling(grid, n,m);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Write(grid[i,j]);
                }
                WriteLine();
            }
            


            ReadLine();
        }
    }
}
