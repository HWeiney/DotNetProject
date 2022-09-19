/**
 * 有一对兔子，从出生后第3个月起每个月都生一对兔子，
 * 小兔子长到第三个月后每个月又生一对兔子，假如兔子都不死，问每个月的兔子对数为多少？
 * 程序分析： 兔子的规律为数列1,1,2,3,5,8,13,21....
 * */
using System;

namespace HomeWork01
{
    class Program
    {
        static int NewRabbitOfMonth(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 0;
            }
            else
            {
                return NewRabbitOfMonth(n - 1) + NewRabbitOfMonth(n - 2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第几个月");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1;i <= n; i++)
            {
                sum += NewRabbitOfMonth(i);
            }
            Console.Write("第" + n + "个月共有" + sum + "对兔子");
        }
    }
}
