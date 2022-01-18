using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _081_02_classInheritance
{
    class Super
    {
        protected int a;

        public Super()
        {
            a = 100;
            Console.WriteLine("  Call Super 생성자 호출");
        }

        ~Super()
        {
            Console.WriteLine("  Call Super 소멸자 호출");
        }
    }
    

    class Sub : Super
    {
        public Sub()
        {
            Console.WriteLine("Call Sub 생성자 호출");
        }

        ~Sub()
        {
            Console.WriteLine("Call Sub 소멸자 호출");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sub sub = new Sub();
        }
    }
}
