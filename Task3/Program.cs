using System;
using static System.Console;
using static System.Double; //  We'll not use enother types in this solution, it's bed example for other problems;
using static System.Math;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the basises of trapeze and the angle on largest basis ( separated by lines ) :");

            double firstBasis = Parse(ReadLine());
            double secondBasis = Parse(ReadLine());
            double angle = Parse(ReadLine());

            WriteLine($"The result is { ((firstBasis + secondBasis) / 2) *  Abs( (Abs(firstBasis - secondBasis) / 2 ) * Tan(angle) ) }");

            ReadKey();
        }
    }
}
