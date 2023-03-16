using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LeetCode7
    {
        public int Reverse(int x)
        {
            if (x > int.MaxValue || x < int.MinValue)
            {
                return 0;
            }

            while (x % 10 == 0)
            {
                x = x / 10;
            }
            string s = "";
            string strI = Math.Abs(x).ToString();
            for (int i = strI.Length - 1; i >= 0; i--)
            {
                s += strI.Substring(i, 1);
            }
            string bf = (x > 0 ? "" : "-") + s;
            Console.WriteLine(bf);
            return Convert.ToInt32(bf);
        }

        public int Batter(int x)
        {
            int res = 0;
            while (x != 0)
            {
                if (x > int.MaxValue / 10 || x < int.MinValue / 10)
                    return 0;

                int end = x % 10;
                x /= 10;
                res = res * 10 + end;
            }
            Console.WriteLine(res);
            return res;
        }
    }
}
