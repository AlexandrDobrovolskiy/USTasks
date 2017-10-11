using System;
using static System.Double; //  We'll not use enother types in this solution, it's bed example for other problems;
using static System.Console;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter a and b (separated by lines) :");

            double a = Parse(ReadLine());
            double b = Parse(ReadLine());


            WriteLine($"Your equation is {a}x = {b}");
            if (a == 0)
                WriteLine("There is no roots.");
            else
                WriteLine($"x = {b / a}");


            ReadKey();
        }
    }
}
