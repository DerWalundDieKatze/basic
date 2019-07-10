using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13方法的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 提示用户输入两个数字  计算这两个数字之间所有整数的和

            //    //提示用户输入两个数字  计算这两个数字之间所有整数的和
            //    //1.提示用户只能输入数字
            //    //2.计算两个数字之间的和
            //    //3.要求第一个数字必须比第二个数字小  就重新输入

            //    Console.WriteLine("请输入第一个数字");
            //    string n1 = Console.ReadLine();
            //    int number1 = GetNumber(n1);
            //    Console.WriteLine("请输入第二个数字");
            //    string n2 = Console.ReadLine();
            //    int number2 = GetNumber(n2);
            //    Judge(ref number1, ref number2);
            //    int sum = GetSum(number1, number2);
            //    Console.WriteLine("{0}到{1}之间的总和是{2}", number1, number2, sum);
            //    Console.ReadKey();
            //}
            ///// <summary>
            ///// 获得一个整数 
            ///// </summary>
            ///// <param name="StrNumber"></param>
            ///// <returns></returns>
            //public static int GetNumber(string StrNumber)
            //{
            //    while (true)
            //    {
            //        try
            //        {
            //            int number = Convert.ToInt32(StrNumber);
            //            return number;
            //        }
            //        catch
            //        {
            //            Console.WriteLine("输入有误,请重新输入");
            //            StrNumber = Console.ReadLine();
            //        }
            //    }

            //}

            ///// <summary>
            ///// 比较输入的两个数字的大小
            ///// </summary>
            ///// <param name="n1"></param>
            ///// <param name="n2"></param>
            //public static void Judge(ref int n1, ref int n2)
            //{
            //    while (true)
            //    {
            //        if (n1 < n2)
            //        {
            //            return;
            //        }
            //        else
            //        {
            //            Console.WriteLine("第一个数不可以大于第二个数,请重新输入第一个数字");
            //            string s1 = Console.ReadLine();
            //            n1 = GetNumber(s1);
            //            Console.WriteLine("请重新输入第二个数字");
            //            string s2 = Console.ReadLine();
            //            n2 = GetNumber(s2);
            //        }
            //    }

            //}
            ///// <summary>
            ///// 求两个数字之间的和
            ///// </summary>
            ///// <param name="n1"></param>
            ///// <param name="n2"></param>
            ///// <returns></returns>
            //public static int GetSum(int n1, int n2)
            //{
            //    int sum = 0;
            //    for (int i = n1; i <= n2; i++)
            //    {
            //        sum += i;
            //    }
            //    return sum;
            //}
            #endregion

            #region 有一个字符串数组：{ "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" },请输出最长的字符串
            //    //用方法来实现 有一个字符串数组：{ "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" },请输出最长的字符串
            //    string[] name = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //    string max = GetLongest(name);
            //     Console.WriteLine("这组字符串的最长的字符串为{0}",max);
            //    Console.ReadKey();

            // }
            ///// <summary>
            ///// 得到最长字符串
            ///// </summary>
            ///// <param name="name"></param>
            ///// <returns></returns>
            //public static string GetLongest(string[] name)
            //{
            //    string max = name[0];
            //    for (int i = 0; i < name.Length; i++)
            //    {
            //        if (name[i].Length > max.Length)
            //        {
            //            max = name[i];
            //        }
            //    }
            //    return max;
            //}
            #endregion

            #region 请计算出一个整型数组的平均值。
            //用方法来实现：请计算出一个整型数组的平均值。
            //    int[] nums = { 1,2,3,4,5,6,7,8,9};
            //    int Age = GetAge(nums);
            //    Console.WriteLine("这组整形数组的平均值是{0}",Age);
            //    Console.ReadKey();
            //}

            //public static int GetAge(int[] nums)
            //{
            //    int sum = 0;
            //    int Age = 0;
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        sum += nums[i];
            //        Age = sum / nums.Length;
            //    }
            //    return Age;
            //}
            #endregion


            //写一个方法，用来判断用户输入的数字是不是质数 再写一个方法 要求用户只能输入数字 输入有误就一直让用户输入数字
            //只能被1和自身整除的数字叫做质数
            Console.WriteLine("请输入一个质数");
            string s = Console.ReadLine();
            int i=GetNumber(ref s);
            int 
        }

        //要求用户只能输入数字,输入有误就一直让用户输入数字
        /// <summary>
        /// 提示用户只能输入数字
        /// </summary>
        /// <param name="n"></param>
        public static int GetNumber(ref string n)
        {
            int s = 0;
            while(true)
            {
                try
                {
                    s = Convert.ToInt32(n); 
                }
                catch
                {
                    Console.WriteLine("输入的不是数字,请重新输入");
                }
            }
        }

        /// <summary>
        /// 判断用输入的数字是否为质数
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        //用来判断用户输入的数字是不是质数
        public static bool  GetNumber1(ref bool b)
        {
            int c = 0;
            while (true)
            {
             if(c%c!=0||c % 1 != 0)
                {
                    return true;
                }
             else
                {
                    Console.WriteLine("输入有误,请重新输入");
                }
            }
        }

    }
}
