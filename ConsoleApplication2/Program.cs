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
            

            int x = 2, y = 5;
            Boolean z = (x > 0) || (y < 8);//||都必须符合条件
            Console.WriteLine("z={0}", z);
            z = (x == 0) && (y < 8);//&&只有一个符合条件
            Console.WriteLine("z={0}",z);
            z = !(x == 2);//!不等于
            Console.WriteLine("z={0}", z);
        }
    }
}
