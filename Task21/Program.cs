using System;
using static System.Console;

namespace Task21
{
    class Program
    {

        static void Inverses(int[] array, ref int count)
        {
            count = 0;

            for (int i = 0; i < array.Length - 1; i++)
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                        count++;
                }
        }

        static void Main(string[] args)
        {
            WriteLine("Enter array (separate values by space): ");

            string[] inputs = ReadLine().Split();
            int[] arr =  new int[inputs.Length];

            for(int i = 0; i < inputs.Length; i++)
                arr.SetValue(int.Parse(inputs[i]), i);

            int count = 0;

            Inverses(arr, ref  count);

            WriteLine($"The count of inverses is {count}");

            ReadKey();
        }
    }
}
