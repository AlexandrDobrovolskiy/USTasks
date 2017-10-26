using System;
using System.Collections.Generic;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter n: ");
            int n = int.Parse(ReadLine());

            List<int> result = Algorithms.getFibbo(n);

            foreach (int num in result)
            {
                Write($"{num} ");
            }

            ReadKey(); 
        }
    }
}
