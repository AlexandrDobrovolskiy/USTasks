using System;
using System.Collections.Generic;
using System.Text;

namespace Task19
{
    static class Math
    {
        public static int Pow(int num, int pow)
        {
            if (pow == 0) return 1;

            if (pow % 2 == 1) return Pow(num, pow - 1) * num;

            else
            {
                int b = Pow(num, pow / 2);
                return b * b;
            }
        }
    }
}
