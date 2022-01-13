using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//out : 전달하는 변수 초기화 없이 사용 가능, 레퍼런스

namespace _063_Func_out
{
    class Program
    {
        static void InitNum(out int addNum)
        {
            addNum = 100;
        }

        static void InitRefNum(ref int refNum)
        {
            refNum = 100;

        }
            
        static void Main(string[] args)
        {
            int a=0;
            int b=0;

            InitNum(out a); //a = 100;
            Console.WriteLine("a: " + a);

            InitRefNum(ref b); //ref는 초기화 하고 사용해야함
            Console.WriteLine("b: " + b);

        }
    }
}
