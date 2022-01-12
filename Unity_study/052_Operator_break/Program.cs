using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//무한루프 제어 : break, continue, goto
namespace _052_Operator_break
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = 0;
            while (true)
            {
                Console.WriteLine("(1)구구단 중 몇 단?   (2)나가기(0번 입력)");
                inputNum = int.Parse(Console.ReadLine());

                if (inputNum == 0)
                {
                    Console.WriteLine("종료 합니다.");
                    break;
                }

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", inputNum, i, (inputNum * i));

                }
            }

        }
    }
}
