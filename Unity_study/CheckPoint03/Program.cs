using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CheckPoint03
{
    class Program
    {
        const int MAP_X = 7;
        const int MAP_Y = 22;
        const int DELAY_TIME = 300;

        static void UpdateView(char[] _tile, int[,] _map)
        {
            for (int i = 0; i < MAP_X; i++)
            {
                for (int j = 0; j < MAP_Y; j++)
                {
                    int tileindex = _map[i, j];
                    Console.Write(_tile[tileindex]);

                    if (j == MAP_Y - 1)
                        Console.WriteLine();
                }
            }

        }

        static void ClearView()
        {
            Thread.Sleep(DELAY_TIME);
            Console.Clear();


        }

        static void UpdateGo(int[] _arrIndexX, int[,] _map)
        {
            for (int i = 0; i < _arrIndexX.Length; i++)
            {
                int indexMaxX = i + 1;
                int indexY = _arrIndexX[i];

                int temp = _map[indexMaxX, indexY];
                _map[indexMaxX, indexY + 1] = temp;
                _map[indexMaxX, indexY] = 0;

                _arrIndexX[i]++;
                //if (_arrIndexX[i] < 20)
                    

            }

        }
        static bool UpdateRandomGo(int[] _arrIndexX, int[,] _map, Random _rnd)
        {
            bool isFinish = false;

            for (int i = 0; i < _arrIndexX.Length; i++)
            {
                if (_arrIndexX[i] >= 20)
                {
                    isFinish = true;
                    break;
                }
            }

            int rndIndex = _rnd.Next(0, 5); // 0 ~ 4

            int indexY = _arrIndexX[rndIndex];


            int temp = _map[rndIndex + 1, indexY];
            _map[rndIndex + 1, indexY + 1] = temp;
            _map[rndIndex + 1, indexY] = 0;

            _arrIndexX[rndIndex]++;

            return isFinish;


        }

        static void Main(string[] args)
        {

            Random rnd = new Random();
            char[] tile = { ' ', '-', '|', '1', '2', '3', '4', '5' };

            int[,] map = new int[MAP_X, MAP_Y]
            {
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
                {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2},
                {4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2},
                {5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2},
                {6,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2},
                {7,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2},
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
            };

            int[] arrIndexX = { 0, 0, 0, 0, 0 };
            bool isFinish = false;

            while (true)
            {
                

                UpdateGo(arrIndexX, map);

                isFinish= UpdateRandomGo(arrIndexX, map, rnd);
                
                UpdateView(tile, map);

                if (isFinish)
                {
                    Console.WriteLine();

                    for (int i = 0; i < arrIndexX.Length; i++)
                    {
                        if (arrIndexX[i] >= 20)
                        {
                            Console.Write("달리기 결과=> 1등: {0}", (i + 1));
                            break;
                        }
                    }

                    Console.Write("\n다시 시작하려면 0을 입력");
                    string inputSr = Console.ReadLine();

                    if (inputSr == "0")
                    {
                        map[1, arrIndexX[0]] = 0;
                        map[2, arrIndexX[1]] = 0;
                        map[3, arrIndexX[2]] = 0;
                        map[4, arrIndexX[3]] = 0;
                        map[5, arrIndexX[4]] = 0;

                        arrIndexX[0] = 0;
                        arrIndexX[1] = 0;
                        arrIndexX[2] = 0;
                        arrIndexX[3] = 0;
                        arrIndexX[4] = 0;

                        map[1, 21] = 2;
                        map[2, 21] = 2;
                        map[3, 21] = 2;
                        map[4, 21] = 2;
                        map[5, 21] = 2;

                        map[1, 0] = 3;
                        map[2, 0] = 4;
                        map[3, 0] = 5;
                        map[4, 0] = 6;
                        map[5, 0] = 7;
                    }
                    else
                    {
                        Console.Write("\n나가기");
                        break;
                    }
                }


                ClearView();

            }



        } 
    }
}
