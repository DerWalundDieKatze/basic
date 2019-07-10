using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //int[] nums = new int[10];

            ////表示通过一个循环给数组赋值
            ////表示将0-9这10个数字,一次的赋值给数组中的每一个元素
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = i;
            //}
            //// 表示通过一个循环给数组取值
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    //nums[i]  两种理解方式:1代表数组中当前循环到的这个元素  2由于在循环中,也可以认为数组中的每一个元素
            //    sum += nums[i];
            //}
            // Console.WriteLine(sum);


            //从一个整数数组中取出最大的整数,最小整数,总和,平均值
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int max = int.MinValue;//nums[0];
            //int min = int.MaxValue;// nums[0];
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if(nums[i]>max)
            //    {
            //        max = nums[i];
            //    }
            //    if (nums[i] < min)
            //    {
            //        min = nums[i];
            //    }
            //    sum +=nums[i];
            //}
            //Console.WriteLine("这个数组中的最大值是{0},最小值是{1},总和是{2},平均值是{3}",max,min,sum,sum/nums.Length);
            //Console.ReadKey();

            //int[] nums = { 1, 2, 3, 4, 5, 6 };
            //int max = nums[0];
            //int min = nums[0];
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if(nums[i]>max)
            //    {
            //        max = nums[i];
            //    }
            //    if(nums[i]<min)
            //    {
            //        min = nums[i];
            //    }
            //    sum += nums[i];
            //}
            //Console.WriteLine("这个数组的最大值是{0},最小值是{1},平均值是{2},总和是{3}",max,min,sum/nums.Length,sum);
            //Console.ReadKey();

            //计算一个整数数组的所有元素的和
            //int[] nums = {1,2,3,4,5,6 };
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    sum += nums[i];
            //}
            //Console.WriteLine("数组的总和是{0}",sum);
            //Console.ReadKey();

            //数组里面都是人的名字,分割成:例如:老杨|老苏|老邹..."(老杨,老苏,老邹,老虎,老牛,老蒋,老马,老王)
            //string[] name = { "老杨"," 老苏", "老邹", "老虎", "老牛", "老蒋", "老马", "老王" };
            //string str = null;
            //for (int i = 0; i < name.Length-1; i++)
            //{
            //    str += name[i]+"|";
            //}
            //Console.WriteLine(str+name[name.Length-1]);
            //Console.ReadKey();

            //string[] name = { "老杨", " 老苏", "老邹", "老虎", "老牛", "老蒋", "老马", "老王"};
            //string str = null;
            //for (int i = 0; i < name.Length-1; i++)
            //{
            //    str += name[i] + "|";
            //}
            //Console.WriteLine(str+name[name.Length-1]);
            //Console.ReadKey();

            //将一个整数数组的每一个元素进行如下的处理:如果元素是正数则将这个位置的元素值加1,如果元素是负数则将这个位置的元素的值减1,如果元素是0,则不变.
            //int[] nums = { -1,-2,-3,0,1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int n1 = nums[0];
            //int n2 = nums[0];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //  if(nums[i]>0)
            //    {
            //        n1=nums[i] + 1;
            //    }
            //  else if(nums[i]<0)
            //    {
            //        n2 = nums[i] - 1;
            //    }
            //  else
            //    {

            //    }
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey();

            //将一个字符串数组的元素的顺序进行反转.{"我","是","好人"}{"好人","是","我"}.第i个和第length-i-1个进行交换
            string[] names = { "abc", "哇哈哈", "Hello", "张三", "金X恩" };
            for (int i = 0; i < names.Length/2; i++)
            {
                string temp = names[i];
                names[i] = names[names.Length - 1 - i];
                names[names.Length - 1 - i] = temp;

            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
             Console.ReadKey();  
        }
    }
}
