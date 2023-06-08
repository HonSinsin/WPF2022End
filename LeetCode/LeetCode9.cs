using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LeetCode9
    {
        public bool IsPalindrome(int para)
        {
            bool result = false;
            // 数字溢出返回false
            if (para > int.MaxValue || para < int.MinValue)
                return result;
            // 负数返回false
            else if (para >= 0)
            {
                string sPara = para.ToString();
                int len = sPara.Length / 2;
                // 长度为1 返回true
                if (sPara.Length == 1) result = true;
                // 奇数时截取[0,中间-1]翻转对比[中间+1,结尾]
                else if ((sPara.Length & 1) == 1) result = string.Concat(sPara[..len].Reverse()) == sPara[(len + 1)..];
                // 偶数时截取两侧翻转对比
                else if ((sPara.Length & 1) == 0) result = string.Concat(sPara[..len].Reverse()) == sPara[len..];
            }
            return result;
        }
    }
}
