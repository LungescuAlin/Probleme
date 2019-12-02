using System;
using System.Collections.Generic;
using System.Text;

namespace teme_ffs
{
    public class P6
    {
        public string Accum(string txt)
        {
            string r = "";
            for(int i=0;i<txt.Length;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    if(j==0)
                    {
                        r += char.ToUpper(txt[i]);
                    }
                    else
                    {
                        r += char.ToLower(txt[i]);
                    }
                }
                if(i<txt.Length-1)
                
                    r += '-';
            }
            return r;
        }
    }
}
