using System;
using System.Collections.Generic;
using System.Text;

namespace teme_ffs
{
    public class P2
    {
        public string Convb(int n)
        {
            string b="";
            string r = "";
            while(n>0)
            {
                b += n % 2;
                
                n /= 2;
            }
            for (int i = b.Length - 1; i >= 0; i--)
                r += b[i];
            return r;
            
        }
       
    }
}
