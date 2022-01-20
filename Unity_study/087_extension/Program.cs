using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _087_extension
{

    class AA
    {
        public void View(string str)
        {
            Console.WriteLine("PrintAA {0}", str);
        }
    }

    static class Util
    {
        public static void Print (this AA aa, string str)
        {
            aa.View(str);
        }

        public static void Sum(this int a)
        {
            Console.WriteLine("{0} + {1} = {0}", a, a, a + a);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();

            Util.Print(aa, "Hello");
            aa.Print("Hello");

            Util.Sum(10);
            10.Sum();
        }
    }
}
