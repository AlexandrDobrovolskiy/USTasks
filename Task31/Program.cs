using System.Collections.Generic;
using static System.Console;

namespace Task31
{
    class Program
    {
        

        static void Main(string[] args)
        {
            WriteLine("Enter n: ");
            int n = int.Parse(ReadLine());

            Algorithms.SplitNum(new []{n});

            ReadKey();
        }
    }
}
