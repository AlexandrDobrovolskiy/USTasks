using System;
using static System.Console;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {

            string number = "";
            bool isValid = true;

            while (isValid)
            {
                WriteLine("Enter number ( 100 <= number <= 999) : ");

                number = ReadLine();

                if (number.Length == 3)
                {
                    WriteLine($"The result is {int.Parse(Convert.ToString(number[0])) + int.Parse(Convert.ToString(number[1])) + int.Parse(Convert.ToString(number[2]))}.");
                    isValid = false;
                }
            }


            ReadKey();
        }
    }
}
