using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02结构
{
    //声明一个结构Mycolor 并分别定义为int类型的red,green,blue
    public struct MyColor
    {
        public int _red;
        public int _green;
        public int _blue;
    }

    //定义一个结构类型为Person,有三个成员,分别为姓名,性别,年龄,性别用枚举类型
    struct Person
    {
        public string _name;
        public int _age;
        //声明一个枚举类型并命名为gender.0   
        public gender _gender;
    }
    //声明一个枚举
       public enum gender
        {
            男,
            女,
        }
        
    class Program
    {
        static void Main(string[] args)
        {
            //声明一个Mycolor类型的变量并为这个变量取名为color,并对其成员进行赋值,使Mycolor可以表示成一个颜色
            MyColor color;
            color._red = 255;
            color._green = 0;
            color._blue = 0;

            //声明两个Person类型的变量,分别表示为张三 男 18岁/小兰 女 16岁
            Person ZPerson;
            ZPerson._name = "张三";
            ZPerson._age = 18;
            ZPerson._gender = gender.男;
            //声明第二个Person类型的变量,分别对其赋值
            Person xPerson;
            xPerson._name = "小兰";
            xPerson._age = 16;
            xPerson._gender = gender.女;
        }
    }
}
