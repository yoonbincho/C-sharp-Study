using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037_Operator4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int a = 100;
            int b = 1000;

            result = (a == b);
            Console.WriteLine("(a == b): {0}", result);

            result = (a != b);
            Console.WriteLine("(a != b): {0}", result);

            result = (a > b);
            Console.WriteLine("(a > b): {0}", result);

            result = (a < b);
            Console.WriteLine("(a < b): {0}", result);

            result = (a >= b);
            Console.WriteLine("(a >= b): {0}", result);

            result = (a <= b);
            Console.WriteLine("(a <= b): {0}", result);

        }
    }
}
