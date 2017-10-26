using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp1
{
    static class Algorithms
    {

        public static List<int> getFibbo(int n)
        {
            List<int> res = new List<int>(){0, 1 };

            for (int i = 1; i < n - 1 ; i++)
            {
                res.Add(res[i - 1] + res[i]);
            }

            return res;
        }
    }
}
