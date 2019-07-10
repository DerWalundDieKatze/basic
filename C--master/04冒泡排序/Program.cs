using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //升序排序 降序排序
            //int [] nums = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = 0; j < nums.Length-1-i; j++)
            //    {
            //        if(nums[j]>nums[j+1])
            //        {
            //            int temp = nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp;
            //        }
            //    }
            //}
            ////输出数组
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey();

            int[] nums = {9,8,5,2,1,4,3,0};
            Array.Sort(nums);//sort这个方法只能对数组进行升序排序
            Array.Reverse(nums);//反转数组;
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadKey();
        }
    }
}
