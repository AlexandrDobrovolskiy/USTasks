using System;

namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number end it's power please: ");
            string[] inputs = Console.ReadLine().Split();

            double n = double.Parse(inputs[0]);
            int pow = int.Parse(inputs[1]);
 
            Console.WriteLine(Math.Pow(n, pow));

            Console.ReadKey();
        }
    }
}
