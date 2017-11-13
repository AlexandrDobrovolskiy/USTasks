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
                    int k = a.Length - b.Length;
                    if (a[i + k] + b[i] > 9)
                    {
                        a[i + k - 1]++;
                        a[i + k] = (a[i + k] + b[i]) % 10;
                    }
                    else a[i + k] += b[i];
                }
                
                return a;
            }
            for (int i = b.Length - 1; i >= 0; i--)
            {
                int k = b.Length - a.Length;
                if (a[i] + b[i + k] > 9)
                {
                    b[i + k - 1]++;
                    b[i + k] = (a[i] + b[i + k]) % 10;
                }
                else b[i + k] += a[i];
            }
            return b;
        }
    }
}
