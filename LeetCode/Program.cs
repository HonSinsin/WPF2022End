using System;

delegate void NumberChanger(int n);
namespace LeetCode
{
    internal class Program
    {
        static int num = 20;
        public static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("Named Method: {0}", num);
        }

        public static void MultNum(int q)
        {
            num *= q;
            Console.WriteLine("Named Method: {0}", num);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine(new LeetCode7().Reverse(12345));          // 整数反转
            //Console.WriteLine(new LeetCode13().RomanToInt("MCMXCIV"));  // 罗马数字转整数
            Console.WriteLine(new LeetCode14().GetString(new string[] { "MCMXCIV" }));  // 最长公共前缀
            Console.ReadKey();

            return;
            // 使用匿名方法创建委托实例
            NumberChanger nc = delegate (int x)
            {
                Console.WriteLine("Anonymous Method: {0}", x);
            };
            // 使用匿名方法调用委托
            nc(10);
            // 使用命名方法实例化委托
            nc = new NumberChanger(AddNum);
            // 使用命名方法调用委托
            nc(5);
            // 使用另一个命名方法实例化委托
            nc = new NumberChanger(MultNum);
            // 使用命名方法调用委托
            nc(2);

            string[] s = { "", "" };
        }
    }
}
