using System;
using static System.Console;

namespace Task8
{
    class Program
    {

        static string changeDirection()
        {
            int ran = new Random().Next(1, 5);
            string dir = "";

            switch (ran)
            {
                case 1:
                    dir = "UR";
                    break;
                case 2:
                    dir = "UL";
                    break;
                case 3:
                    dir = "DR";
                    break;
                case 4:
                    dir = "DL";
                    break;

            }
            return dir;
        }

        static void Game(string[,] array, string direction, int currentA, int currentB, int totalA, int totalB)
        {
            
        }


        static void Main(string[] args)
        {
            WriteLine("Enter a and b (sizes of the box) :");
            int a = int.Parse(ReadLine());
            int b = int.Parse(ReadLine());

            string[,] grid = new string[a + 2, b + 2];

            for (int i = 0; i < a + 2; i++)
            {
                for (int j = 0; j < b + 2; j++)
                {
                    grid[i, j] = "  ";
                    if ((i == 0) || (i == a + 1) || (j == 0) || (j == b + 1))
                        grid[i, j] = "#|";
                }
            }
            Clear();

            string direction = "DR";
            int currentA = 1;
            int currentB = 1;

            while (true)
            {
                if (grid[currentA, currentB] == "#|")
                    changeDirection();

                switch (direction)
                {
                    case "UL":
                        if (grid[currentA - 1, currentB - 1] == "#|")
                            direction = changeDirection();
                        else
                        {
                            grid[currentA, currentB] = "  ";
                            grid[currentA - 1, currentB - 1] = "@|";
                            currentA--;
                            currentB--;
                        }
                        break;
                    case "UR":
                        if (grid[currentA - 1, currentB + 1] == "#|")
                            direction = changeDirection();
                        else
                        {
                            grid[currentA, currentB] = "  ";
                            grid[currentA - 1, currentB + 1] = "@|";
                            currentA--;
                            currentB++;
                        }
                        break;
                    case "DL":
                        if (grid[currentA + 1, currentB - 1] == "#|")
                            direction = changeDirection();
                        else
                        {
                            grid[currentA, currentB] = "  ";
                            grid[currentA + 1, currentB - 1] = "@|";
                            currentA++;
                            currentB--;
                        }
                        break;
                    case "DR":
                        if (grid[currentA + 1, currentB + 1] == "#|")
                            direction = changeDirection();
                        else
                        {
                            grid[currentA, currentB] = "  ";
                            grid[currentA + 1, currentB + 1] = "@|";
                            currentA++;
                            currentB++;
                        }
                        break;
                }

                string res = "";

                for (int i = 0; i < a + 2; i++)
                {

                    for (int j = 0; j < b + 2; j++)
                    {
                        res += grid[i, j];
                    }
                    res += "\n";
                }
                WriteLine(res);
                WriteLine(currentA + " " + currentB);
                System.Threading.Thread.Sleep(50);
                Clear();
            }

            ReadKey();
        }
    }
}
