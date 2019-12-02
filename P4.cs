using System;
using System.Collections.Generic;
using System.Text;

namespace teme_ffs
{
    public class P4
    {
       
        public bool ValidateEmail(string s)
        {
            int a = s.IndexOf("@");
            int b = s.IndexOf(".");
            if (a<=0||b<=0||b<a)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
