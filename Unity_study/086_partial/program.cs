﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _086_partial
{
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            aa.SetNum(10);
            aa.ADD();

            aa.SetNum(100);
            aa.MUL();
        }
    }
}
