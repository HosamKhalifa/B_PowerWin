using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PowerWin.SharedExt
{
    public static class StringExt
    {
        public static bool IsNotNull(this string _string)
        {
            return string.IsNullOrEmpty(_string) == false;
        }
         
    }
}
