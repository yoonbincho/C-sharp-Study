using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 100);
            int num = 1;
            while (true)
            {


                Console.WriteLine("0~99사이 어떤 숫자일까요(단, 0은 나가기)");
                string str = Console.ReadLine();
                int input = int.Parse(str);
                

                if (input == 0)
                {
                    break;
                }
                else if (input > a)
                {
                    Console.WriteLine("입력한 수는 커요");
                    
                }
                else if (input < a)
                {
                    Console.WriteLine("입력한 수는 작아요");
                    
                }
                else
                {
                    Console.WriteLine("=== 정답 입니다. ===");
                    
                    Console.WriteLine("총 {0}번 시도", num);

                    break;
                }
                ++num;


            }
        }
    }
}
