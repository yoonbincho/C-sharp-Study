using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CheckPoint01
{
    class Program
    {
        static void Main(string[] args)

        {
            Random rnd = new Random();
            int runA = 0;
            int runB = 0;
            int runC = 0;
            int runD = 0;

            const string Line = "--------------------------------------";
            const int END_LINE = 36;

            while (true)
            {
                Thread.Sleep(300); //딜레이
                Console.Clear();//화면 지우기

                ++runA;
                ++runB;
                ++runC;
                ++runD;
                int rndNum = rnd.Next(0, 4); //0~3

                switch (rndNum)
                {
                    case 0:
                        ++runA;
                        break;
                    case 1:
                        ++runB;
                        break;
                    case 2:
                        ++runC;
                        break;
                    case 3:
                        ++runD;
                        break;

                }


                Console.WriteLine(Line);
                
                for (int i = 0; i < runA; i++)
                    Console.Write(" ");
                Console.Write("1");

                for (int i = END_LINE - runA; i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                for (int i = 0; i < runB; i++)
                    Console.Write(" ");
                Console.WriteLine("2");

            

                for (int i = 0; i < runC; i++)
                    Console.Write(" ");
                Console.WriteLine("3");

              
                for (int i = 0; i < runD; i++)
                    Console.Write(" ");
                Console.WriteLine("4");

               

                Console.WriteLine(Line);

                if (runA >= END_LINE || runB >= END_LINE || runC >= END_LINE || runD >= END_LINE)
                {
                    int runNum = 0;
                    string strResult = "결과: {0} 선수 우승!";

                    if (runA >= END_LINE)
                        runNum = 1;
                    else if (runB >= END_LINE)
                        runNum = 2;
                    else if (runC >= END_LINE)
                        runNum = 3;
                    else if (runD >= END_LINE)
                        runNum = 4;
                    Console.WriteLine(strResult, runNum);

                    Console.WriteLine("다시 하시려면 0번 입력:");
                    if ("0" == Console.ReadLine())
                    {
                        runA = 0;
                        runB = 0;
                        runC = 0;
                        runD = 0;

                    }
                    else
                        break;

                }

            }
           
        }
    }
}
