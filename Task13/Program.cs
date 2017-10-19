using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter m: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your matrix (values separate by space, lines - by \"Enter\"): ");

            double[,] matrix = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split();

                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(inputs[j]);
                }
            }

            Console.WriteLine("OK, here is new matrix: ");

            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i ++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
