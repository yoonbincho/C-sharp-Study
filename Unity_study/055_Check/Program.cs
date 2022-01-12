using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2개의 랜덤 정수의 합을 맞추는 프로그램
namespace _055_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for(int i=1; i < 6; i++)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 100);
                int b = rnd.Next(0, 100);

                Console.WriteLine("{0}: 다음 두 수의 합은 몇?(총 5문제)", i);
                Console.WriteLine("{0} + {1} = ??", a, b);

                int sum = a + b;


                string str = Console.ReadLine();
                int input = int.Parse(str);


                if (sum == input)
                {
                    Console.WriteLine("==정답==");

                }
                else
                {
                    Console.WriteLine("오답(정답은 {0})", sum);
                }




            }

          
        }
    }
}
