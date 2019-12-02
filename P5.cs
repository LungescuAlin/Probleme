using System;
using System.Collections.Generic;
using System.Text;

namespace teme_ffs
{
    public class P5
    {
        public string MakeTitle(string txt)
        {
            string r = "";
            if (txt.Length != 0)
            {  r = "" + char.ToUpper(txt[0]);
                if (txt.Length!=1)
                for (int i = 1; i < txt.Length; i++)
                {
                    r += txt[i];

                        if (txt[i] == 32)
                        {
                            if (txt[txt.Length-1] != txt[i])
                            {
                                r += char.ToUpper(txt[i + 1]);
                                i++;
                            }
                            
                        }
                
                    }
            }

            return r;
        }
    }
}
