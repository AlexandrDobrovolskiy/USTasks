using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixMultiplying
{
    class Matrix
    {
        private int[,] elements;

        private int n, m;

        public Matrix(int[,] elements, int n, int m)
        {
            Elements = elements;
            N = n;
            M = m;
            
        }

        public static Matrix Multiplying(Matrix first, Matrix second)
        {
            int[,] newElements = new int[first.N,second.M];

            for (int i = 0; i < 3; i++)
            {
                for (int l = 0; l < 3; l++)
                {
                    for (int j = 0; j < 3; j++)
                        newElements[i, l] += first.Elements[i, l] + second.Elements[i, j];
                }

            }
            return new Matrix(newElements, first.N,second.M);
        } 


        public int[,] Elements { get => elements; set => elements = value; }
        public int N { get => n; set => n = value; }
        public int M { get => m; set => m = value; }
    }
}
