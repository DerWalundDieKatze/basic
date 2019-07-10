using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法判断用户是否登录成功
            #region
            //如果登录成功返回一个true,并返回一条登录信息
            //如果登录失败,则返回一个false 返回一条错误信息
            //string msg;
            //Console.WriteLine("请输入用户名");
            //string username = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string userPwd = Console.ReadLine();
            //bool b = IsLogin(username,userPwd,out msg);
            //Console.WriteLine(b);
            //Console.WriteLine(msg);
            //Console.ReadKey();
            //}
            // 判断用户是否登录成功
            ///// <summary>
            ///// 判断用户是否登录成功
            ///// </summary>
            ///// <param name="username">输入用户名</param>
            ///// <param name="userPwd">输入密码</param>
            ///// <param name="msg">多余要返回信息</param>
            ///// <returns>登录是否成功</returns>
            //public static bool IsLogin(string username,string userPwd,out string msg)
            //{
            //    if(username=="admin"&&userPwd=="888888")
            //    {
            //        msg = "登陆成功";
            //        return true;
            //    }
            //    else if(username!="admin")
            //    {
            //        msg = "用户名错误";
            //        return false;

            //    }
            //    else if(userPwd!="888888")
            //    {
            //        msg = "密码错误";
            //        return false;
            //    }
            //    else
            //    {
            //        msg = "未知错误";
            //        return false;
            //    }
            //}
            #endregion

            //写一个方法判断用户是否登录成功
            //如果登录成功返回一个true,并返回一条登录信息
            //如果登录失败,则返回一个false 返回一条错误信息
                string msg;
                Console.WriteLine("请输入用户名");
                string userName = Console.ReadLine();
                Console.WriteLine("请输入密码");
                string userPwd = Console.ReadLine();
                bool b = IsLogin(userName, userPwd, out msg);
                Console.WriteLine("登录结果是{0}", b);
                Console.WriteLine("登录信息是{0}", msg);
                

        }
        /// <summary>
        /// 判断用户是否登录成功
        /// </summary>
        /// <param name="userName">输入用户名</param>
        /// <param name="userPwd">输入密码</param>
        /// <param name="msg">多余要返回的信息</param>
        /// <returns>返回登录结果和登录信息</returns>
        public static bool IsLogin(string userName,string userPwd,out string msg)
        {
            if(userName=="admin"&&userPwd=="123")
            {
                msg = "登录成功";
                return true;
               
            }
            else if(userName=="admin")
            {
                msg = "密码错误";
                return false;
            }
            else if(userPwd=="123")
            {
                msg = "用户名错误";
                return false;
            }
            else
            {
                msg = "未知错误";
                return false;
            }

        }
    }
}
