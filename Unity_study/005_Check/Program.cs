using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                Console.WriteLine("지금 듣는 강의는 {0} {1} 좋아요!!", args[0], args[1]);
               

                Console.ReadKey();

            }
           
        }
    }
}
