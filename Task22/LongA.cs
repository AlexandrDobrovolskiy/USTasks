using System;
using System.Collections.Generic;
using System.Text;

namespace Task22
{
    static class LongA
    {
        public static int[] LongAddition(int[] a, int[] b)
        {
            if (a.Length > b.Length)
            {
                for (int i = b.Length - 1; i >= 0; i--)
                {
                    if (a[i] + b[i] > 9)
                    {
                        a[i - 1]++;
                        a[i] = (a[i] + b[i]) % 10;
                    }
                    else a[i] += b[i];
                }
                
                return a;
            }
            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (a[i] + b[i] > 9)
                {
                    b[i - 1]++;
                    b[i] = (a[i] + b[i]) % 10;
                }
                else b[i] += a[i];
            }
            return b;
        }
    }
}
