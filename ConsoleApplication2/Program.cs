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
            int i = 1;
            int a = i++;
            int b = ++i;
            Console.WriteLine(a);//num++为1
            Console.WriteLine(b);//++num为3
        }
    }
}
