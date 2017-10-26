using System;
using static System.Console;


namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter array you want (separate values by space): ");            
            string[] inputs = ReadLine().Split();
            int res = int.Parse(inputs[0]);

            for (int i = 1; i < inputs.Length; i++)
            {
                if (res < int.Parse(inputs[i])) res = int.Parse(inputs[i]); // I wish to use Array.Sort() for big arrays but in this poblem we have less then 100 numbers
            }

            WriteLine($"The bigest element is {res}.");
            
            ReadKey();
        }
    }
}
