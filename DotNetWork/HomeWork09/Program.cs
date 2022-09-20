/**
 * 一球从100米高度自由落下，每次落地后反跳回原高度的一半；
 * 再落下，求它在 第10次落地时，共经过多少米？第10次反弹多高？
 */
using System;

namespace HomeWork09
{
    class Program
    {
        static void Main(string[] args)
        {
			float h, s;
			h = s = 100;
			h = h / 2;
			for (int i = 2; i <= 10; i++)
			{
				s = s + 2 * h;
				h = h / 2;
			}
			Console.WriteLine("第10次落地时，共经过{0}米，第10次反弹高{1}米\n", s, h);
		}
    }
}
