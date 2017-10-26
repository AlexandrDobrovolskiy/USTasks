using System;
using static System.Console;
using static System.Double;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter n :");

            double n = Parse(ReadLine());

            WriteLine($"The root is {Math.Sqrt(n)}.");

            ReadKey();
        }
    }
}
