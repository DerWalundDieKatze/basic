using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01枚举
{

    public  enum QQstate
    {
        OnLine=1,
        OffLine,
        Leave,
        Busy,
        QMe,
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 将枚举类型强转换为int类型
            //枚举类型和int类型相互兼容
            //int n1 =(int)QQstate.OnLine;
            //Console.WriteLine(n1);
            //Console.WriteLine((int)QQstate.OffLine);
            //Console.WriteLine((int)QQstate.Leave);
            //Console.WriteLine((int)QQstate.Busy);
            //Console.WriteLine((int)QQstate.Me);
            //Console.ReadKey();
            #endregion

            #region 将int类型强制转换为枚举类型
            //int n1 = 10;
            //QQstate s1 = (QQstate)n1;
            //Console.WriteLine(s1);
            //Console.ReadKey();
            #endregion

            #region 将枚举类型转换为字符串类型，调用ToString()
            //QQstate s = QQstate.OnLine;
            //Console.WriteLine(s.ToString());
            //Console.ReadKey();
            #endregion

            #region 将字符串类型转换成枚举类型
            //QQstate s1 = (QQstate)Enum.Parse(typeof(QQstate), "Hello");
            //Console.WriteLine(s1);
            //Console.ReadKey();
            #endregion

            #region QQ在线状态
            //while (true)
            //{
            //    Console.WriteLine("请选择您的QQ在线状态  1--Online,2--OffLine,3--Leave,4--Busy,5--QMe");
            //    string input = Console.ReadLine();//1-5
            //    switch (input)
            //    {
            //        case "1":
            //            QQstate s1 = (QQstate)Enum.Parse(typeof(QQstate), input);
            //            Console.WriteLine("您选择的在线状态是{0}", s1);
            //            break;
            //        case "2":
            //            QQstate s2 = (QQstate)Enum.Parse(typeof(QQstate), input);
            //            Console.WriteLine("您选择的在线状态是{0}", s2);
            //            break;
            //        case "3":
            //            QQstate s3 = (QQstate)Enum.Parse(typeof(QQstate), input);
            //            Console.WriteLine("您选择的在线状态是{0}", s3);
            //            break;
            //        case "4":
            //            QQstate s4 = (QQstate)Enum.Parse(typeof(QQstate), input);
            //            Console.WriteLine("您选择的在线状态是{0}", s4);
            //            break;
            //        case "5":
            //            QQstate s5 = (QQstate)Enum.Parse(typeof(QQstate), input);
            //            Console.WriteLine("您选择的在线状态是{0}", s5);
            //            break;

            //  }
            //    Console.ReadKey();
            // }
            #endregion


        }
    }
}