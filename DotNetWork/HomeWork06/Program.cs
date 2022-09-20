/**
 * 输入两个正整数m和n，求其最大公约数和最小公倍数。
 */
using System;

namespace HomeWork06
{
    class Program
    {
        static int MaxNum(int m,int n)
        {
            if (m < n)
            {
                int temp = m;
                m = n;
                n = temp;
            }
            int r = 1;
            while (r != 0)
            {
                r = m % n;
                m = n;
                n = r;
            }
            return m;

        }

        static int MinNum(int m,int n)
        {
            return m * n / MaxNum(m, n);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("输入正整数m和n: ");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("最大公约数是：" + MaxNum(m, n));
            Console.WriteLine("最小公倍数是：" + MinNum(m, n));
        }
    }
}
