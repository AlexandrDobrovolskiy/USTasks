using System;
using static System.Console;
using static System.Double;

namespace Task9
{
    class Program
    {

        static double Root(double n)
        {
            double lo = 0, hight = n, midle = -1 ;
            for (int i = 0; i < 1000; i++)
            {
                midle = (lo + hight) / 2;
                if (midle * midle == n) return midle;
                if (midle * midle > n)
                {
                    hight = midle;
                }
                else
                {
                    lo = midle;
                }
            }
            return midle;
        }

        static void Main(string[] args)
        {
            Write("Enter n :");
            double n = Parse(ReadLine());

            WriteLine($"The root is {Root(n)}.");

            ReadKey();
        }
    }
}
