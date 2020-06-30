using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul8
{
    class Chain2
    {
        int x;
        int y;
        int z;
        public Chain2() : this(1)
        {
            Console.WriteLine("Arg count 0");
        }
        public Chain2(int x) : this(x, 4,3)
        {
            Console.WriteLine("Arg count 1");
        }

        public Chain2(int x, int y)
        {

            this.x = x;
            this.y = y;
            this.z = 3;
            Console.WriteLine("Arg count 2");
        }

        public Chain2(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            Console.WriteLine("Arg count 3");
        }
    }

    class OtherChains
    {
    }
}
