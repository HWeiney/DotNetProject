/**
 * 一个数如果恰好等于它的因子之和，这个数就称为"完数"。例如6=1＋2＋3.编程找出1000以内的所有完数。
 */
using System;

namespace HomeWork08
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;//存放因子之和
            int i = 0;

            for (i = 1; i <= 1000; i++)
            {
                sum = 0;
                for (int j = 1; j < i; j++)//判断因子
                {
                    if (i % j == 0)
                    {
                        sum += j;//求和
                    }

                }
                if (sum == i)//看因子和是否等于i
                {
                    Console.WriteLine(i);//如果相等，输出i
                }
            }
        }
    }
}
