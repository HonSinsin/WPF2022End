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
            // 定义一个接收最长公共字符串的char数组
            var result = new List<char>();
            // 找到最短字符串
            var length = strs.Min(str => str.Length);
            for (int i = 0; i < length; i++)
            {
                // 获取到字符串数组中第i个字符
                var set = new HashSet<char>(strs.Select(s => s[i]));
                // 如果第i个字符都是一样的,那么hashSet<char>长度是1
                // 否则长度>1
                if (set.Count == 1)
                    result.Add(strs[0][i]);
                else
                    break;
            }

            return new string(result.ToArray());
        }
    }
}
