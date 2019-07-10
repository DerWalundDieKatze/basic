using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12RecursiveMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //方法的递归  在方法内部自己调用自己
            //找一个文件夹下的所有文件
            TellStory();
            Console.ReadKey();
        }
        public static int i = 0;

        public static void TellStory()
        {
            i++;
            Console.WriteLine("从前有座山");
            Console.WriteLine("山里有座庙");
            Console.WriteLine("庙里有个老和尚");
            Console.WriteLine("老和尚在给小和尚讲故事");
            if(i>=5)
            {
                return;
            }
            TellStory();
        }
    }
}
