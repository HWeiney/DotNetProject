/**
 * 有1、2、3、4个数字，能组成多少个互不相同且无重复数字的三位数？都是多少？
 */
using System;

namespace HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 4; i++) //三层循环，分别是百位，十位，个位。
            {
                int bw = i;
                for (int j = 1; j <= 4; j++)
                {
                    int sw = j;
                    if (bw != sw)
                    {
                        for (int k = 1; k <= 4; k++)
                        {
                            int gw = k;
                            if (gw != bw && gw != sw)
                            {
                                count++;
                                Console.WriteLine("{0}{1}{2}", bw, sw, gw);
                            }
                        }
                    }
                }
            }
            Console.WriteLine("一共有：" + count + "个");
            Console.Read();
        }
    }
}
