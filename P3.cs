using System;
using System.Collections.Generic;
using System.Text;

namespace teme_ffs
{
    public class P3
    {
        public List<int> b = new List<int>();
        public bool IsSymmetrical(int n)
        {
            while(n>0)
            {
                b.Add(n % 10);
                n /= 10;
            };

            for(int i=0;i<b.Count/2;i++)
            {
                if (b[i] != b[b.Count - 1 - i])
                    return false;
            }

            return true;
        }
    }
}
