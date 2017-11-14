using System;

namespace MatrixMultiplying
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first matrix: ");

            string[] inputs;
            int[,] grid = new int[3,3];

            for (int i = 0; i < 3; i++)
            {
                inputs = Console.ReadLine().Split();
                for (int j = 0; j < 3; j++)
                    grid[i, j] = int.Parse(inputs[j]);
            }

            Matrix firstMatrix = new Matrix(grid,3,3);
            Console.WriteLine("Enter second matrix: ");

            for (int i = 0; i < 3; i++)
            {
                inputs = Console.ReadLine().Split();
                for (int j = 0; j < 3; j++)
                    grid[i, j] = int.Parse(inputs[j]);
            }


            Matrix secondMatrix = new Matrix(grid,3,3);

            Matrix result = Matrix.Multiplying(firstMatrix,secondMatrix);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{result.Elements[i,j]} ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
