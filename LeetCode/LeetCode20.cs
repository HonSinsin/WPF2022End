using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LeetCode20
    {
        public bool IsValid(string para)
        {
            int iPara = para.Length;
            if ((iPara & 1) == 0)
            {
                iPara /= 2;
                while (iPara-- > 0)
                {
                    para = para.Replace("()", "").Replace("[]", "").Replace("{}", "");
                }
                return para.Length == 0;
            }
            return false;

            //int bCount = 0, mCount = 0, sCount = 0;
            //foreach (var item in para)
            //{
            //    switch (item)
            //    {
            //        case '(': sCount++; break;
            //        case ')': sCount--; break;
            //        case '[': mCount++; break;
            //        case ']': mCount--; break;
            //        case '{': bCount++; break;
            //        case '}': bCount--; break;
            //    }
            //}

            //return sCount == mCount && mCount == bCount && bCount == 0;
        }
    }
}
