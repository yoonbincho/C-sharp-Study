using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_HelloWorld3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  static void Main(string[] args)"); //
        }

        static void Main()
        {
            Console.WriteLine("  static void Main");
        }

        static int Main()
        {
            Console.WriteLine("  static int Main");
            return 0;
        }

        static int Main(string[] args)
        {
            Console.WriteLine("AAA{0} BBB{1}", 1, "ggg");
            Console.WriteLine("  static int Main(string[] args)");
            return 0;
        }
    }
}
