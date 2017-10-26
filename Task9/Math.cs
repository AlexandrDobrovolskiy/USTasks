using System;
using System.Collections.Generic;
using System.Text;

namespace Task9
{
    static class Math
    {
        public static double Sqrt(double n)
        {
            double lo = 0, hight = n, midle = -1;
            for (int i = 0; i < 1000; i++)
            {
                midle = (lo + hight) / 2;
                if (midle * midle == n) return midle;
                if (midle * midle > n) hight = midle;
                else lo = midle;
            }
            return midle;
        }

    }
}
