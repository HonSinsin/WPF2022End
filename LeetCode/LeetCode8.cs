using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LeetCode8
    {
        public int MyAtoi(string para = " -42")
        {
            para = "00000-42a1234";
            para = para.Trim();

            if (para.IndexOf("+-") >= 0 || para.IndexOf("-+") >= 0)
            {
                return 0;
            }
            if (para.Length == 0 || para.Length > 200)
            {
                return 0;
            }
            var item0 = para[0];

            if ((item0 != '+' && item0 != '-') && (item0 <= 48 || item0 > 57))
            {
                return 0;
            }

            while (para.IndexOf("0") == 0)
            {
                para = para.TrimStart('0');
            }

            int result = 0;
            string cArray = String.Empty;
            foreach (var item in para)
            {
                if ((item >= 48 && item <= 57) || (item == '+' || item == '-'))
                {
                    cArray += (item.ToString());
                }
                else
                {
                    break;
                }
            }
            string res = string.Empty;
            bool less0 = false;
            if (cArray.Length > 0)
            {
                if (cArray[0] == '-')
                {
                    res = string.Concat(cArray.Skip(1).Take(cArray.Length - 1).ToArray());
                    less0 = true;
                }
                else if (cArray[0] == '+')
                {
                    res = string.Concat(cArray.Skip(1).Take(cArray.Length - 1).ToArray());
                }
                else
                {
                    res = string.Join("", cArray);
                }
            }

            if (res.Length > 0)
            {
                long resul = Convert.ToInt64(res);
                if (less0)
                {
                    resul = 0 - resul;
                }
                if (resul > (Math.Pow(2, 31) - 1))
                {
                    result = int.MaxValue;
                }
                else if (resul < (Math.Pow(-2, 31)))
                {
                    result = int.MinValue;
                }
                else
                {
                    result = (int)resul;
                }
            }
            return result;
        }
    }
}
