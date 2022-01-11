using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Data4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0b11111111;//2진수
            int b = 0xFF;//16진수
            int num = 255;

            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: "+b);
            Console.WriteLine("num: " + num);
        }
    }
}
