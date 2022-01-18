using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _080_static
{
    class AA
    {
        public static int a;
        public static int b;
        public static readonly int c = 200;

        public static void Print()
        {
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);
        }

    }

    class BB
    {
        public int a;
        public int b;

        public void Print()
        {
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            AA.a = 10;
            AA.b = 100;
            //c는 변경 불가(읽기 전용)

            AA.Print();//객체 생성 안해도 바로 접근 가능

            //BB.a, BB.b, BB.print 모두 오류 -> 객체 생성 해줘야함

            BB bb = new BB();

            bb.a = 100;
            bb.b = 200;

            bb.Print();
        }
    }
}
