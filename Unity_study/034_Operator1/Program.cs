using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034_Operator1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine("c: " + c);

            int d = a / b;
            Console.WriteLine("d: " + d);

            int e = a * (b + c);
            Console.WriteLine("e: " + e);

            int f = (a + b) % 2;
            Console.WriteLine("f: " + f);
        }
    }
}
