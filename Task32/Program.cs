using System;

namespace Task32
{
    class Program
    {
        static void Main(string[] args)
        {
            string separator = Console.ReadLine();
            string input = Console.ReadLine();

            Console.WriteLine(input.Split(new []{separator}, System.StringSplitOptions.None).Length - 1);


            Console.ReadKey();
        }
    }
}
