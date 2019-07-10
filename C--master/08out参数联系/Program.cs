using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08out参数联系
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用out参数返回一个数组的最大值,最小值,总和,平均值
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int max;
            int min;
            int sum;
            int avg;
            GetMaxMinSumAvg(nums, out max, out min, out avg, out sum);
            Console.WriteLine("最大值为{0}",max);
            Console.WriteLine("最小值为{0}",min);
            Console.WriteLine("总和为{0}",sum);
            Console.WriteLine("平均值为{0}",avg);
            Console.ReadKey();
        }
        /// <summary>
        /// 返回一个数组的最大值,最小值,总和,平均值
        /// </summary>
        /// <param name="nums">输入要计算的数组</param>
        /// <param name="max">返回最大值</param>
        /// <param name="min">返回最小值</param>
        /// <param name="Avg">返回平均值</param>
        /// <param name="sum">返回总和</param>
        public static void GetMaxMinSumAvg(int[] nums,out int max,out int min,out int Avg,out int sum)
        {
            max = nums[0];
            min = nums[0];
            sum = 0;
           
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i]>max)
                {
                    max = nums[i];
                   
                }
                else if(nums[i]<min)
                {
                    min = nums[i];
                   
                }
                else
                {

                }
                sum += nums[i];
                
            }
            Avg = sum / nums.Length;
        }
    }
}
