using System;
using System.Collections.Generic;
using System.Text;

namespace Task19
{
    static class Math
    {
        public static double Pow(double n, int pow)
        {
            if (pow == 1)
                return n;
            else if (pow == 0)
                return 1;
            else if (pow > 1)
                return n * Pow(n, pow - 1);
            else
                throw new ArgumentOutOfRangeException();
        }
    }
}
