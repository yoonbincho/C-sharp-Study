using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _059_Func2
{
    class Program
    {
        static int Add()
        {
            int a = 0;
            return ++a;
        }

        static int InputNum()
        {
            Console.Write("입력하려는 정수를 넣어주세요? ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
        static void Main(string[] args)
        {
            int num = 0;
            num += Add();

            Console.WriteLine("Num: " + num);
            Console.WriteLine("입력하신 정수는 {0}", InputNum());
        }
    }
}
