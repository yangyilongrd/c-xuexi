using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 迭代语句do.while语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //屏幕上输出1-50的数字
            //int num = 0;
            //do
            //{

            //    num++;
            //    Console.WriteLine(num);

            //}
            //while (num <=50);
            //Console.ReadLine();
            //do...while语句至少执行一次即使while条件不成立时。



            //计算现金存入银行多长时间才可以达到我们的预期收益（均按一年期定期存款，到期后自动转存）
            //本金 目标收益 利率  时间（年）
            //一年收益:本金X（1+利率）X1年=目标收益
            //

            double  benjing = 0;
            double  lilv = 0;
            double  ningxian = 0;
            double  mubiaoshouyi = 0;
            Console.WriteLine("请输入你的本金");
            benjing = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入你的利率");
            lilv = double.Parse(Console.ReadLine())/100;
            Console.WriteLine("请输入你的目标收益");

            do
            {
                mubiaoshouyi = double.Parse(Console.ReadLine());
                if (mubiaoshouyi <= benjing) Console.WriteLine("你没有必要存钱");

            }
            while (mubiaoshouyi <= benjing);
            do
            {
                benjing *= (lilv + 1);
                ningxian ++;

            } while (benjing < mubiaoshouyi);
            Console.WriteLine("你将在{0}年内，获得{1}的收益", ningxian, mubiaoshouyi);
            Console.ReadLine ();

            
        }


    }
}
