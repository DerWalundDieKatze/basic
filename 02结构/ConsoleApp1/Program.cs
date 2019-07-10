using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //将一周的7天定义为weekdays枚举并定义为整型类型,将设今天是周五,计算15天后是周几
    //创建weekdays枚举
    public enum Weekdays
    {
        //男,
        
            Monday=1,
            Tuesday=2,
            Wednesday=3,
            Thursday=4,
            Friday=5,
            Saturday=6,
            Sunday=7
    };
    //public enum Session
    //{
    //    //春,
    //    //夏,
    //    //秋,
    //    //冬
    //}

        //定义主函数,首先获取周五所对应的整数,用该数加15获取15天后的数值,将该值执行除以7取余运算,获取其所对应的枚举数值,接着获取枚举所对应的星期数,输出15天后是周几
    class Program
    {

        static void Main(string[] args)
        {
            //Gender gender = Gender.女;
            //Session sessi = Session.冬;

            int now = (int)Weekdays.Friday;
            int next = (now + 15) % 7;
            if(next==0)
            {
                Console.WriteLine("15天后是Sunday");
            }
            else
            {
                Weekdays nextday=(Weekdays)next;
                Console.WriteLine("15天后是{0}",nextday);
                //上述代码首先根据星期数获取对应的数值,接着使用数值获取所对应的星期数.代码的执行结果如下:15天后是Saturday
            }

        }
    }
}
