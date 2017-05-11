using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region i++和++i
            //int i = 1;
            //int a = i++;
            //int b = ++i;
            //Console.WriteLine(a);//num++为1
            //Console.WriteLine(b);//++num为3
            #endregion
            #region &&和||
            //int x = 2, y = 5;
            //Boolean z = (x > 0) || (y < 8);//||都必须符合条件
            //Console.WriteLine("z={0}", z);
            //z = (x == 0) && (y < 8);//&&只有一个符合条件
            //Console.WriteLine("z={0}",z);
            //z = !(x == 2);//!不等于
            //Console.WriteLine("z={0}", z);
            #endregion
            #region 三元运算符
            //Console.WriteLine("请输入成绩");
            //int score = int.Parse(Console.ReadLine());
            //string succ = score >= 60 ? "及格" : "不及格";//三元运算符
            //Console.WriteLine(succ);
            #endregion
            #region 隐式转换
            //string a;
            //a = 10 + "2a0";
            //Console.WriteLine(a);  //隐式转换
            //double z = 3.15;
            //int x = 2;
            //double y = x + z;
            //Console.WriteLine(y);
            #endregion
            #region 显式转换
            //int a = 1;
            //double b = 3.14159;
            //int c = (int)(a + b);  //数据类型转换  显式转换
            //Console.WriteLine(c);
            //int d = 987;
            //string e = d.ToString();//ToString()方法
            //Console.WriteLine(e);

            // int.Parse();
            // string g = "12345";
            //int h = Convert.ToInt32(g);  //这个方法可以很多类型转换
            #endregion
            #region 类型转换
            string s1 = "123";
            string s2 = "90.8";
            int s3 = int.Parse(s1);
            double s4 = Convert.ToDouble(s2);
            Console.WriteLine("{0}---{1}", s3, s4);
            int k = 12;
            double d = 12.56;
            string k1 = k.ToString();
            string d1 = Convert.ToString(d);
            Console.WriteLine("{0}----{1}", k1, d1);
            #endregion
          
        }
    }
}
