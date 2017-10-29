using System;
using static System.Math;
using static System.Int32;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter x, y, and z, they migth be separated by lines :");

            int x = Parse(Console.ReadLine());
            int y = Parse(Console.ReadLine());
            int z = Parse(Console.ReadLine());

            Console.WriteLine($"The result is { Sin( (x + Pow(x,2) + Pow(z,3) ) / ( 1 + Pow((x + y + z),2)) ) * Sqrt( Abs( x + y + z) ) }");


            Console.ReadKey();
        }
    }
}
