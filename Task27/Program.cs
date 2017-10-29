using System;
using static System.Console;


namespace Task27
{
    class Program
    {

        public static string GetDecomposition(int n)
        {
            string res = "";

            for (int i = 2; true;)
            {
                if (n % i != 0)
                {
                    i++;
                    continue;
                }
                int k = n / i;
                res += $"{i} ";
                n = k;

                if (n == 1)
                    break;

                res += "x ";
            }

            return res;
        }
        static void Main(string[] args)
        {
            Write("Enter n: ");
            int n = int.Parse(ReadLine());

            WriteLine($"The result is {GetDecomposition(n)}");
            ReadKey();
        }
    }
}