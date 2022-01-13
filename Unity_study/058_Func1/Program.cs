﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _058_Func1
{
    class Program
    {
        static void InitTitle()
        {
            Console.WriteLine("짝수 & 홀수 보여주기 (0 ~ 100)");
        }

        static void PrintEven()
        {
            for(int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(" 짝수: {0}", i);

                if (i % 10 == 0 && i != 0)
                    Console.WriteLine();
            }
        }

        static void PrintOdd()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(" 홀수: {0}", i);

                if (i % 10 == 1 && i != 1)
                    Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            InitTitle();
            PrintEven();
            PrintOdd();

        }
    }
}
