using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using static System.Console;

namespace Task39
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter n: ");
            int n = int.Parse(ReadLine());
            WriteLine("Enter grid (separate values by space, rows - by \"Enter\"): ");

            Node[,] grid = new Node[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] inputs = ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    grid[i, j] = new Node(int.Parse(inputs[j]),i,j);
                }
            }

            List<int> list = new List<int>();

            Algorithms.FindPath(grid);

            

            ReadKey();
        }
    }
}
