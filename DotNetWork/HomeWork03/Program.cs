/**
 * 打印出所有的"水仙花数"，所谓"水仙花数"是指一个三位数，其各位数字立方和等于该数本身。
 * 例如：153是一个"水仙花数"，因为153=1的三次方＋5的三次方＋3的三次方。
 * 程序分析：利用for循环控制100-999个数，每个数分解出个位，十位，百位。
 */
using System;

namespace HomeWork03
{
    class Program
    {
        static void Main(string[] args)
        {
			int i = 100, gw, sw, bw;
			for (i = 100; i < 1000; i++)
			{
				gw = i % 10;
				bw = i / 100;
				sw = (i - bw * 100) / 10;
				if (i == gw*gw*gw + bw*bw*bw + sw*sw*sw)
				{
					Console.WriteLine(i + " ");
				}
			}
		}
    }
}
