using System;
using System.Collections.Generic;
using System.Text;

namespace teme_ffs
{
    public class P10
    {
        public string ToCamelCase(string txt)
        {
            string r = "";
            for(int i=0;i<txt.Length;i++)
            {

                if (txt[i] == 95)
                {
                    r += char.ToUpper(txt[i + 1]);
                    i++;
                }
                else r += char.ToLower(txt[i]);
            }
            return r;
           
            }
        public string ToSnakeCase(string txt)
        {
            string r = "";
            for (int i = 0; i < txt.Length; i++)
            {

                if (txt[i] >= 65 && txt[i] <= 90)
                {
                    r += "_";
                    r += char.ToLower(txt[i]);
                }
                else r += txt[i];
            }
            return r;
        }
    }
}
