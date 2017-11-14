using System;
using static System.Console;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter a: ");

            string[] inputs = Regex.Split(ReadLine(), @"");
            int[] a = new int[inputs.Length -1];
            for (var i = 1; i < inputs.Length-1; i++)
                a[i] = int.Parse(inputs[i]);

            WriteLine("Enter b: ");
            inputs = Regex.Split(ReadLine(), @"");
            int[] b = new int[inputs.Length -1];
            for (var i = 1; i < inputs.Length -1; i++)
                b[i ] = int.Parse(inputs[i]);

            WriteLine();
            int[] c = LongA.LongAddition(a, b);

            Write("\n");

            foreach (int num in c)
                Write(num);


            Console.ReadKey();
        }
    }
}
