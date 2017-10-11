using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter your number :");
            ulong num = ulong.Parse(ReadLine());
            ulong sum = 0;

            do
            {
                sum += num % 10;
                num /= 10;

            } while (num != 0);

            WriteLine($"The result is {sum}.");

            ReadKey();
        }
    }
}