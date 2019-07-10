  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  方法
            //写一个方法 返回数字中的最大值
            //    GetMax(5,8);

            //    //写一个方法,计算一个整数数组中的最大值
            //    int[] nums = { 1,2,3,4,5,6,7,8,9};
            //    int max = GetMaxTwo(nums);
            //    Console.WriteLine(max);
            //    Console.ReadKey();

            //    int a = 3;
            //    int aNew = (5);//实参
            //}
            //public static int Test(int a)//形参
            //{
            //    a = a + 5;
            //    return a;
            //}
            //public static void TestTwo(int a)
            //{

            //}
            ///// <summary>
            ///// 计算一个整数数组中的最大值
            ///// </summary>
            ///// <param name="numbers">要计算的数组</param>
            ///// <returns>返回这组数组中的最大值</returns>
            // public static int GetMaxTwo(int[] numbers)
            //{
            //    int max = 0;
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        if(numbers[i]>max)
            //        {
            //            max = numbers[i];
            //        }

            //    }
            //    return max;
            //}
            ///// <summary>
            ///// 比较两个数字钟的最大值,并返回最大值
            ///// </summary>
            ///// <param name="n1">要比较的数字1</param>
            ///// <param name="n2">要比较的数字2</param>
            ///// <returns>返回比较的最大的数字</returns>
            //public static int GetMax(int n1,int n2)
            //{
            //    return n1>n2?n1:n2;
            //}
            #endregion

            #region 判断闰年
            //    //写一个方法,判断所给的年份是否是闰年 true false bool 类型
            //    //需要给一个年份作为参数
            //    Console.WriteLine("请输入要判断的年份");
            //    int year = Convert.ToInt32(Console.ReadLine());
            //    bool b = IsRun(year);
            //    Console.WriteLine(b);
            //    Console.ReadKey();
            //}
            ///// <summary>
            ///// 判断所输入年份是否是闰年
            ///// </summary>
            ///// <param name="year">输入的年份</param>
            ///// <returns>返回是否是闰年</returns>
            //public static bool IsRun(int year)
            //{
            //    //    if((year%400==0)||(year%4==0&&year%100!=0))
            //    //    {
            //    //        return true;
            //    //    }
            //    //    else
            //    //    {
            //    //        return false;
            //    //    }
            //    return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            //}
            #endregion

            //读取输入的整数,定义成方法
            //多次调用(如果用户输入的是数字,则返回,否则提示用户重新输入)
            //Console.WriteLine("请输入一个数字");
            //string str = Console.ReadLine();
            //int s=GetNumber(str);
            //Console.WriteLine(s);
            //Console.ReadKey();
            Console.WriteLine("请输入要判断的字符串");
            string str1 = Console.ReadLine();
            string strNew = IsYouN(str1);
            Console.WriteLine("您输入的是{0}", strNew);
            Console.ReadLine();

            //计算输入数组的和
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = GetSum(nums);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        /// <summary>
        /// 计算输入数组的和
        /// </summary>
        /// <param name="nums">要计算的数组</param>
        /// <returns>返回数组的和</returns>
        public static int GetSum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                
            }
            return sum;
        }
        /// <summary>
        /// 判断用户输入的是否是yes或者no,只要不是,就重新输入
        /// </summary>
        /// <param name="input">要判断的字符串</param>
        /// <returns>yes或者no</returns>
        public static string IsYouN(string input)
        {
            while(true)
            {
                if(input!="yes"&&input !="no")
                {
                    Console.WriteLine("输入有误,请重新输入");
                    input = Console.ReadLine();
                }
                else
                {
                    return input;
                }
            }

        }
        /// <summary>
        /// 将用户输入的字符串转换成int类型
        /// </summary>
        /// <param name="strNumber">用户输入的字符串</param>
        /// <returns>返回转换成功后的整数</returns>
        //public static int GetNumber(string strNumber)
        //{
        //    while (true)
        //    {
        //        try
        //        {
        //            int number = Convert.ToInt32(strNumber);
        //            return number;
        //        }
        //        catch
        //        {
        //            Console.WriteLine("请重新输入");
        //            strNumber = Console.ReadLine();
        //        }
        //    }
        //}

    }
}
