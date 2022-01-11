using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041_Operator_null
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            int b = 10;
            int? c = null;
            int d = 100;
            int result;

            result = a ?? b;
            Console.WriteLine("result: "+ result);

            result = a ?? c ?? d;
            Console.WriteLine("result: "+ result);

            c = 10000000;
            result = a ?? c ?? d;
            Console.WriteLine("result: "+ result);
        }
    }
}
