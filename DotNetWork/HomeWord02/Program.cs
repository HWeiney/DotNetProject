/**
 * 判断101-200之间有多少个素数，并输出所有素数。
 * 程序分析：判断素数的方法：用一个数分别去除2到sqrt(这个数)，
 * 如果能被整除，则表明此数不是素数，反之是素数。
*/
using System;

namespace HomeWord02
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 101; i <= 200; i++) // 质数从2开始到100结束
            {
                bool flag = true;
                for (int j = 2; j < i; j++) // 能被2和到自身的前一个数整除
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    sum++;
                    //Console.WriteLine(sum+ ":"+i + "是质数！");
                }
            }
            Console.WriteLine(sum);
        }
    }
}
