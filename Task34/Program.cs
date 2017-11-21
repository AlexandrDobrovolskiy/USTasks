using System;
using System.Threading.Tasks.Dataflow;

namespace Task34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string (less then 7 chars): ");
            string input = Console.ReadLine();
            char[] chars = new char[input.Length];

            for (int i = 0; i < chars.Length; i++)
                chars[i] = input[i];



            Permute(chars, Output);

            Console.ReadKey();
        }

        private static void Output<T>(T[] permutation)
        {
            foreach (T item in permutation)
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }

        public static void Permute<T>(T[] items, Action<T[]> output)
        {
            Permute(items, 0, new T[items.Length], new bool[items.Length], output);
        }

        private static void Permute<T>(T[] items, int item, T[] permutation, bool[] used, Action<T[]> output)
        {
            for (int i = 0; i < items.Length; ++i)
            {
                if (!used[i])
                {
                    used[i] = true;
                    permutation[item] = items[i];

                    if (item < (items.Length - 1))
                    {
                        Permute(items, item + 1, permutation, used, output);
                    }
                    else
                    {
                        output(permutation);
                    }

                    used[i] = false;
                }
            }
        }
    }
}
