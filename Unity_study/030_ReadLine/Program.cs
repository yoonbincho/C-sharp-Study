using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_ReadLine //한 번에 한 줄씩 문자열로 입력 받음
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요?");
            string inputNum = Console.ReadLine();
            int num = int.Parse(inputNum);

            Console.WriteLine("입력한 수는: " + num);

        }
    }
}
