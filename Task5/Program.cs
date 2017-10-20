using System;
using static System.Double;
using static System.Console;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter A, B and C :");

            double A = Parse(ReadLine());
            double B = Parse(ReadLine());
            double C = Parse(ReadLine());

            Equation myEquation = new Equation(A, B, C);

            WriteLine(myEquation.toString() + "/n" + myEquation.getRoots());
            ReadKey();
        }
    }
}

