using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _065_Func_Overloading
{
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static int Add(int a, int b, int c, int d = 0)
        {
            return (a + b + c + d) * 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Add(int a, int b): " + Add(10, 100));
            Console.WriteLine("Add(int a, int b, int c): " + Add(10, 100, 1000));
            Console.WriteLine("Add(double a, double b): " + Add(10.3, 100.5));

        }
    }
}
