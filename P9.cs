using System;
using System.Collections.Generic;
using System.Text;

namespace teme_ffs
{
    public class P9
    {
        public string ConvertToHex(string txt)
        {
            string r = "";
            string s="";
            int i;
            for (i = 0; i < txt.Length; i++)
            {
                int a = txt[i];
                while (a > 0)
                {
                    if (a % 16 < 10)
                    {
                        r += a % 16;
                    }
                    else
                        if (a % 16 == 10)
                        r += 'a';
                    else
                        if (a % 16 == 11)
                        r += 'b';
                    else
                        if (a % 16 == 12)
                        r += 'c';
                    else
                        if (a % 16 == 13)
                        r += 'd';
                    else
                        if (a % 16 == 14)
                        r += 'e';
                    else
                        r += 'f';

                    a /= 16;
                }
             
            }
            for(i=0;i<r.Length;i++)
            {
                if (i % 2 == 0)
                    s += r[i + 1];
                else
                {
                    s += r[i - 1];
                    
                    if(i!=r.Length-1)
                        s += " ";
                }
            }
            return s;
        }
    }
}
