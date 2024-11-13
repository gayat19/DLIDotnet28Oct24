using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUnderstanding
{
    public static class StringCheck
    {
        public static bool CheckSub(this string s1,string substr)
        {
            return s1.Contains(substr);
        }
    }
}
