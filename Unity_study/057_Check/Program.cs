using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_Check
{
    class Program
    {
        static void Main(string[] args)

            
        {
            int max = 0;
            int min = 0;
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("학생의 성적을 입력하세요: ");
                string str = Console.ReadLine();
                int num = int.Parse(str);


                if (max < num)
                    max = num;
                if (min > num)
                    min = num;

            }
            Console.WriteLine("최대값: {0}   최소값: {1}", max, min);
        }
    }
}
