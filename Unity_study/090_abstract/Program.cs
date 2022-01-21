using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _090_abstract
{

    abstract class abstractAA
    {

        public int num;
        public abstract void abstractPrint(); 

        public virtual void virtualPrint()
        {
        }

        public void Print()
        {
        }
    }

    class AA : abstractAA
    {
        public override void abstractPrint()
        {
            Console.WriteLine("abstractPrint");
        }


        public override void virtualPrint()
        {
            base.virtualPrint();

            Console.WriteLine("override void virtualPrint()");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            aa.abstractPrint();
            aa.virtualPrint();
        }
    }
}