using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_Operator3 //증감연산자
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            Console.WriteLine("num: {0}", num++);
            Console.WriteLine("num: {0}", num);
            Console.WriteLine("num: {0}", ++num);

            Console.WriteLine("\nnum: {0}", num--);
            Console.WriteLine("num: {0}", num);
            Console.WriteLine("num: {0}", --num);

        }
    }
}
