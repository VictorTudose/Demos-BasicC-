using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul8
{
    class Chain
    {
        int x;
        int y;
        int z;
        public Chain() : this(1)
        {
            Console.WriteLine("Arg count 0");
        }
        public Chain(int x) : this(x,4)
        {
            Console.WriteLine("Arg count 1");
        }

        public Chain(int x,int y) :this(x,y,3)
        {
            Console.WriteLine("Arg count 2");
        }

        public Chain(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            Console.WriteLine("Arg count 3");
        }
    }

    class ConstructorChain
    {
        public static void demo()
        {
            Console.WriteLine("Demo liste de constructori");
            Console.WriteLine("--------------------------------");

            Chain c = new Chain();
            Console.ReadKey();
            Console.WriteLine();
            Chain2 c2 = new Chain2();
            Console.ReadKey();
            Console.WriteLine();
            Chain2 c3 = new Chain2(2, 3);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
