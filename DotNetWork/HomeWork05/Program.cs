/**
 *  输入一个学生成绩，输出成绩等级：学习成绩>=90分的同学用A表示，
 *  60-89分之间的用B表示，60分以下的用C表示。
 */
using System;

namespace HomeWork05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入学生成绩:");
            int grade = int.Parse(Console.ReadLine());
            if (grade >= 90)
            {
                Console.WriteLine("成绩等级：A");
            }
            else if(grade>=60 && grade <= 89)
            {
                Console.WriteLine("成绩等级：B");
            }
            else
            {
                Console.WriteLine("成绩等级：C");
            }
        }
    }
}
