﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using static System.Console;

namespace Task14
{


    class Program
    {

        public static int Labeling(int[,] image, int n, int m)
        {
            int L = 1;
            bool hasLabeled = false;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (image[i, j] != 0)
                    {
                        if (!hasLabeled)
                            try
                            {
                                if(image[i - 1, j] != L && image[i + 1, j] != L) L++;
                            }
                            catch (IndexOutOfRangeException) { }
                            
                        
                        image[i, j] = L;
                        try
                        {
                            if (image[i + 1, j] == 1) image[i + 1, j] = L;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            try
                            {
                                if (image[i, j + 1] == 1) image[i, j + 1] = L;
                            }
                            catch (IndexOutOfRangeException) { }
                        }
                        try
                        {
                            if (image[i, j + 1] == 1) image[i, j + 1] = L;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            try
                            {
                                if (image[i + 1, j] == 1) image[i + 1, j] = L;
                            }
                            catch (IndexOutOfRangeException) { }
                        }
                        hasLabeled = true;
                    }else if (image[i, j] == 0)
                    {
                        hasLabeled = false;
                    }
                }
                
            }
            return L;
        }

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

            WriteLine($"This image has{Labeling(grid, n, m)} items, here is it: ");

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
