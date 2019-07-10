using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //交换两个int类型变量
            int n1 = 10;
            int n2 = 20;
            //int temp=n1;
            //n1=n2;
            //n2=temp;

            //n1=n1-n2;
            //n2=n1+n2;
            //n1=n2-n1;
            //Console.WriteLine(n1);
            //Console.WriteLine(n1);

            //Change(out n1, out n2);
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.ReadKey();

            Change(ref n1, ref n2);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.ReadKey();
        }

        //public static void Change(out int n1,out int n2)
        //{
        //    //n1 = n1 - n2;//-10
        //    //n2 = n1 + n2;//10
        //    //n1 = n2 - n1;//10-(-10)
        //    n1 = 100;
        //    n2 = 200;
        //    int temp = n1;
        //    n1 = n2;
        //    n2 = temp;

        //}

        public static void Change(ref int n1,ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
