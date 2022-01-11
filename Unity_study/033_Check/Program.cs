using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("국어 점수를 입력하세요?");
            string str1 = Console.ReadLine();
            int num1 = int.Parse(str1);

            Console.Write("영어 점수를 입력하세요?");
            string str2 = Console.ReadLine();
            int num2 = int.Parse(str2);

            Console.Write("수학 점수를 입력하세요?");
            string str3 = Console.ReadLine();
            int num3 = int.Parse(str3);

            Console.Write("과학 점수를 입력하세요?");
            string str4 = Console.ReadLine();
            int num4 = int.Parse(str4);

            int sum = num1 + num2 + num3 + num4;
            int avg = sum / 4;

            Console.WriteLine("국어: {0}   영어: {1}   수학: {2}   과학: {3}", num1, num2, num3, num4);
            Console.WriteLine("총점: {0}   평균: {1}", sum, avg);
            


           
        }
    }
}
