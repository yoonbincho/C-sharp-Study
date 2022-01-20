using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _083_override
{
    class super
    {
        protected int num;
        public virtual void Print()
        {
            Console.WriteLine("num: {0}", num);
        }
    }

    class AA : super
    {
        public int a;

        public override void Print()
        {
            base.Print();

            Console.WriteLine("AA a: {0}", a);
        }
    }

    class BB : super
    {
        public int b;

        public override void Print()
        {
            base.Print();
            Console.WriteLine("BB b: {0}", b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            super super = new super();
            super.Print();

            super aa = new AA();
            aa.Print();

            super bb = new BB();
            bb.Print();
        }
    }
}
