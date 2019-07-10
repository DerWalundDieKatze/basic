using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05让方法返回多个值
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法,让这个方法返回一个数组的最大值,最小值,总和,平均值
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] numsNew = GetNums(nums);//调用这个方法并将得到的数组重新赋值
            Console.WriteLine("这个数组的最大值是{0},最小值是{1},总和是{2},平均值是{3}", numsNew[0], numsNew[1], numsNew[2], numsNew[2] / nums.Length);
         
            Console.ReadKey();
        }
        /// <summary>
        /// 返回一个数组的最大值,最小值,总和,平均值
        /// </summary>
        /// <param name="nums">需要计算的数组</param>
        /// <returns>返回这个数组的最大值,最小值,总和,平均值</returns>
        public static int[] GetNums(int[] nums)
        {
            int[] numsNew = new int[4];//声明一个数组,假设numsNew[0]是最大值,numsNew[1]是最小值,numsNew[2]是总和,numsNew[3]是平均值
            numsNew[0] = nums[0];//int max=numsNew[0];
            numsNew[1] = nums[0];//int min=numsNew[0];
            for (int i = 0; i < nums.Length; i++)
            {

                //求出最大值
                if (nums[i] > numsNew[0])
                {
                    numsNew[0] = nums[i];
                }
                //求出最小值
                else if(nums[i]<numsNew[1])
                {
                    numsNew[1] = nums[i];
                }
                else
                {

                }
                numsNew[2] += nums[i];
            }
            return numsNew;
          
            
        }
    }
}
