using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038_Operator5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int a = 100;
            int b = 1000;

            result = (a == 100) && (b == 1000);
            Console.WriteLine("(a == 100) && (b ==  1000): {0}", result);

            result = (a == 100) || (b == 1000);
            Console.WriteLine("(a == 100) || (b ==  1000): {0}", result);

            result = (a == 100) && (b == 100);
            Console.WriteLine("(a == 100) && (b ==  100): {0}", result);

            result = (a == 100) || (b == 100);
            Console.WriteLine("(a == 100) || (b ==  100): {0}", result);

            result = false;
            result = !result;
            Console.WriteLine("!result: {0}", result);
            result = !result;
            Console.WriteLine("!result: {0}", result);

        }
    }
}
