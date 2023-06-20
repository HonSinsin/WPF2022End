using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LeetCode58
    {
        public int LengthOfLastWord(string s)
        {
            s = "Today is a nice day";
            return s.Trim().Split(' ',StringSplitOptions.RemoveEmptyEntries).Last().Length;
        }
    }
}
