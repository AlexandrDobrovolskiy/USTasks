using System;

namespace Task40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string input = Console.ReadLine();
            char[] chars = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                chars[i] = input[i];
            }

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '(')
                {
                    for (int j = i; j < chars.Length; j++)
                    {
                        if (chars[j] == ')')
                        {
                            chars[i] = '0';
                            chars[j] = '0';
                        }
                    }
                }
                else if (chars[i] == '[')
                {
                    for (int j = i; j < chars.Length; j++)
                    {
                        if (chars[j] == ']')
                        {
                            chars[i] = '0';
                            chars[j] = '0';
                        }
                    }
                }
            }

            bool isCorrect = true;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != '0')
                {
                    isCorrect = false;
                    break;
                }

            }

            Console.WriteLine(isCorrect ? "Yes" : "No");

            Console.ReadKey();
        }
    }
}
