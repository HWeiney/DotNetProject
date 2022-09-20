/**
 *  输入一行字符，分别统计出其中英文字母、空格、数字和其它字符的个数。
 */
using System;

namespace HomeWork07
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            int le = 0;//统计字母的数量
            int sp = 0;//统计空格的数量
            int num = 0; //统计数字的数量
            int symbol = 0;//统计其它字符的数量
            Console.Write("请输入一段字符:");
            str = Console.ReadLine();
            char[] c = str.ToCharArray();//把字符串转换成字符数组
            foreach (char i in c)
            {
                if (i >= 'a' && i <= 'z' || i >= 'A' && i <= 'Z')
                    le++;
                else if (i >= '0' && i <= '9')
                    num++;
                else if (i == ' ')
                    sp++;
                else
                    symbol++;
            }
            Console.WriteLine("字母有" + le + "个，空格有" + sp + "个，数字有" + num + "个，其它字符有" + symbol + "个.");
        }
    }
}
