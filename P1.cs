using System;
using System.Collections.Generic;
using System.Text;

namespace teme_ffs
{
    public class P1
    {
        
        public int[,] Create(int n)
        {
            int[,] array = new int[100,100];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n - i; j++)
                    array[i, j] = n;
            return array;
        }
    }
}
