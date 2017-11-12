using System;
using static System.Console;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter a: ");

            string inputs = ReadLine();
            int[] a = new int[inputs.Length];
            for (var i = 0; i < inputs.Length; i++)
                a[i] = Convert.ToInt32(inputs[i].ToString());

            WriteLine("Enter b: ");
            inputs = ReadLine();
            int[] b = new int[inputs.Length];
            for (var i = 0; i < inputs.Length; i++)
                b[i] = Convert.ToInt32(inputs[i].ToString());

            int[] c = LongA.LongAddition(a, b);

            Write("\n");

            foreach (int num in c)
                Write(num);

            Console.ReadKey();
        }
    }
}
