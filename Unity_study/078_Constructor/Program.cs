using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _078_Constructor
{
    class AA
    {
        int a;
        float f;

        public AA()
        {
            a = 0;
            f = 0f;
            Console.WriteLine("  Call Constructor  ");
            Console.WriteLine("  a: {0}", a);
            Console.WriteLine("  f: {0}", f);
        }

        public AA(int _a)
        {
            a = _a;

            Console.WriteLine("  Call Constructor  ");
            Console.WriteLine("  a: {0}", a);
            Console.WriteLine("  f: {0}", f);

        }

        public AA(int _a, float _f)
        {
            a = _a;
            f = _f;

            Console.WriteLine("  Call Constructor  ");
            Console.WriteLine("  a: {0}", a);
            Console.WriteLine("  f: {0}", f);

        }

        ~AA()
        {
            Console.WriteLine("  Call Destructor  ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            Console.WriteLine();
            AA aaa = new AA(10);
            Console.WriteLine();
            AA aaaa = new AA(100, 0.5f);
            Console.WriteLine();
        }
    }
}
