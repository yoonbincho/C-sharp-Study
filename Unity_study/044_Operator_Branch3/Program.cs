using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044_Operator_Branch3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isA = false;
            bool isB = true;
            bool isC = true;
            bool isD = false;

            if (isA && isB)
            {
                Console.WriteLine("false && true => false");
            }
            if (isB && isC)
            {
                Console.WriteLine("true && true => true");
            }
            if (isC || isD)
            {
                Console.WriteLine("true && false => true");
            }
            if (2>1 && 3 < 4 || 1 > 2) 
            {
                Console.WriteLine("true && false || false => true");
            }

        }
    }
}
