using System;
using static System.Console;


namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter array you want (separate values by space): ");
            int[] arr = new int[100];
            string[] inputs = ReadLine().Split();

            for (int i = 0; i < inputs.Length; i++)
            {
                arr[i] = int.Parse(inputs[i]);
            }

            Array.Sort(arr);

            WriteLine($"The bigest element is {arr[99]}.");
            
            ReadKey();
        }
    }
}
