using System;
using System.Collections.Generic;
using System.Text;

namespace teme_ffs
{
    public class P7
    {
       
        public int MysteryFunction( int n)
        {
            int mf=1;
            while(n>0)
            {
                mf *= n % 10;
                n /=10;
            }
            return mf;
        }
    }
}
