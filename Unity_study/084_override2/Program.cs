using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _084_override2
{
    class Army
    {
        protected int _HP;
        protected int _MP;
        protected int _Speed;
        protected int _Attack;

        public virtual void run()
        {
            Console.WriteLine("{0}의 속도로", _Speed);
        }

        public virtual void Attack()
        {
            Console.WriteLine();

            if(this is Healer)
            {
                Console.WriteLine("[마법 공격력 - {0}으로 ", _Attack * _MP);
            }
            else
            {
                Console.WriteLine("[공격력 - {0}으로 ", _Attack);

            }
        }
    }

    class Barbarian : Army
    {
        public Barbarian()
        {
            _HP = 100;
            _MP = 0;
            _Speed = 100;
            _Attack = 100;
        }

        public override void run()
        {
            base.run();

            Console.WriteLine("Barbarian 달려갑니다.");
        }

        public override void Attack()
        {
            base.Attack();
            Console.WriteLine("Barbarian이 칼로 공격!.");
        }
    }

    class Giant : Army
    {
        public Giant()
        {
            _HP = 200;
            _MP = 0;
            _Speed = 10;
            _Attack = 200;
        }

        public override void run()
        {
            base.run();

            Console.WriteLine("Giant 달려갑니다.");
        }

        public override void Attack()
        {
            base.Attack();
            Console.WriteLine("Giant 공격!");
        }
    }

    class Healer : Army
    {
        public Healer()
        {
            _HP = 50;
            _MP = 100;
            _Speed = 200;
            _Attack = 10;
        }

        public override void run()
        {
            base.run();

            Console.WriteLine("Healer 날아갑니다.");
        }

        public override void Attack()
        {
            base.Attack();
            Console.WriteLine("Healer 마법 공격!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Army[] arrArmys = new Army[10];

            arrArmys[0] = new Barbarian();
            arrArmys[1] = new Giant();
            arrArmys[2] = new Healer();
            arrArmys[3] = new Healer();
            arrArmys[4] = new Giant();

            for(int i = 0; i < arrArmys.Length; i++)
            {
                if(null != arrArmys[i])
                {
                    arrArmys[i].run();
                    System.Threading.Thread.Sleep(1000);
                }
            }

            System.Threading.Thread.Sleep(1000);

            for (int i = 0; i < arrArmys.Length; i++)
            {
                if (null != arrArmys[i])
                {
                    arrArmys[i].Attack();
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

    }
}
