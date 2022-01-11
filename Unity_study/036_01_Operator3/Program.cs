using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_01_Operator3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 100;

            a += 10;
            Console.WriteLine("a: " + a);

            a -= b;
            Console.WriteLine("a: " + a);

            a *= b;
            Console.WriteLine("a: " + a);

            b /= 3;
            Console.WriteLine("b: " + b);

            b %= 10;
            Console.WriteLine("b: " + b);


        }
    }
}
