using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043_Operator_Branch2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요: ");
            string strNum = Console.ReadLine();
            int a = int.Parse(strNum);

            if (a > 0)
            {
                Console.WriteLine("입력한 수는 양수!");
            }
            else if (a < 0)
            {
                Console.WriteLine("입력한 수는 음수!");
            }
            else
            {
                Console.WriteLine("입력한 수 0이다!");
            }

        }
    }
}
