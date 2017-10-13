using System;
using static System.Console;
using static System.Double;

namespace Task9
{
    class Program
    {

        static double root(double n)
        {
            double lo = 0, hi = n, mid = -1 ;
            for (int i = 0; i < 1000; i++)
            {
                mid = (lo + hi) / 2;
                if (mid * mid == n) return mid;
                if (mid * mid > n)
                {
                    hi = mid;
                }
                else
                {
                    lo = mid;
                }
            }
            return mid;
        }

        static void Main(string[] args)
        {
            Write("Enter n :");
            double n = Parse(ReadLine());

            WriteLine($"The root is {root(n)}.");

            ReadKey();
        }
    }
}
