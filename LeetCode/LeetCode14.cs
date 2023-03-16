using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LeetCode14
    {
        public string GetString(string[] strs)
        {
            strs = new string[] { "abc", "acc", "abd" };
            string str = string.Empty;
            for (int i = 0; i < strs.Length; i++)
            {
                string stri = strs[i];
                string forStr = string.Empty;
                for (int k = 0; k < stri.Length; k++)
                {
                    str = forStr += stri.Substring(k, 1);
                    int match = 0;
                    for (int j = 1; j < strs.Length; j++)
                    {
                        if (strs[j].StartsWith(forStr))
                        {
                            match++;
                            Console.WriteLine(strs[j]);
                        }
                    }
                    if (match == 0)
                    {
                        break;
                    }
                }
            }
            return str;
        }
    }
}
