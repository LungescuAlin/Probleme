using System;
using System.Collections.Generic;
using System.Text;

namespace teme_ffs
{
    public class P8
    {
       public string TestToNum(string txt)
        {
            string r = "";
            for(int i=0;i<txt.Length;i++)
            {
                if (txt[i] >= 65 && txt[i] <= 90)
                {
                    if (txt[i] == 'A' || txt[i] == 'B' || txt[i] == 'C')
                        r += '2';
                    else
                        if (txt[i] == 'D' || txt[i] == 'E' || txt[i] == 'F')
                        r += '3';
                    else
                        if (txt[i] == 'G' || txt[i] == 'H' || txt[i] == 'I')
                        r += '4';
                    else
                        if (txt[i] == 'J' || txt[i] == 'K' || txt[i] == 'L')
                        r += '5';
                    else
                        if (txt[i] == 'M' || txt[i] == 'N' || txt[i] == 'O')
                        r += '6';
                    else
                        if (txt[i] == 'P' || txt[i] == 'Q' || txt[i] == 'R' || txt[i] == 'S')
                        r += '7';
                    else
                        if (txt[i] == 'T' || txt[i] == 'U' || txt[i] == 'V')
                        r += '8';
                    else
                        r += '9';

                }
                else r += txt[i];
            }
            return r;
        }
    }
}
