using System;
using static System.Console;


namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {

            

            WriteLine("Enter first sum (example 1.33 = 1 grn 33 cop): ");

            String[] inputs = ReadLine().Split('.');
            Money sum1 = new Money(int.Parse(inputs[0]), int.Parse(inputs[1]));

            WriteLine("Enter second sum: ");

            inputs = ReadLine().Split('.');
            Money sum2 = new Money(int.Parse(inputs[0]), int.Parse(inputs[1]));


            Money res = Money.Addition(sum1, sum2);
            WriteLine(res.ToString());
            
            res = Money.Subtraction(sum1, sum2);
            WriteLine(res.ToString());

            ReadKey();
        }
    }
}
