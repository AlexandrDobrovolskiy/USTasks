﻿using System;
using System.Linq;

namespace Task31
{
    public class Algorithms
    {
        public static void SplitNum(int[] arrN)
        {
            int lastNum = arrN.Last();
            int mid = lastNum / 2;

            for (int i = 0; i < mid; i++)
            {
                for (int j = 0; j < arrN.Length - 1; j++)
                    Console.Write(arrN[j] + "+");

                Console.WriteLine($"{(mid) - i}+{lastNum - ((mid) - i)}");
            }
            if (lastNum != 1)
            {
                int[] newArrN = new int[arrN.Length + 1];
                for (int i = 0; i < newArrN.Length - 1; i++)
                    newArrN[i] = 1;

                newArrN[arrN.Length] = lastNum - 1;
                SplitNum(newArrN);
            }
        }
    }
}
