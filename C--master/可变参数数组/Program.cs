using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 可变参数数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //求任意数组中的总和
            //int[] s = { 97, 95, 99 };
            //GetScore("张三",98,99,100,200,30);
            //Console.ReadKey();

            int sum = GetScore(1.5,22, 20, 11, 33, 20);
            Console.WriteLine(sum);
            Console.ReadKey();

        }

        //public static void GetScore(string name,int id,params int[] score)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < score.Length; i++)
        //    {
        //        sum += score[i];
        //    }
        //    Console.WriteLine("{0}这次考试的总成绩是{1}",name,sum);
        //}
        public static int GetScore(double b,params int[] nums
            )
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
