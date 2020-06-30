using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul8
{
    class Blob
    {
        int a;
        static int b;
        static Blob()
        {
            b = 2;
            Console.WriteLine("Static constructor made here");
        }
        public Blob()
        {
            a = 1;
            Console.WriteLine("Non-Static constructor made here");
        }
    }


    class StaticConstructor
    {
        public static void demo()
        {
            Console.WriteLine("Demo constructori statici");
            Console.WriteLine("--------------------------------");
            Blob b = new Blob();
            Blob c = new Blob();
            Blob d = new Blob();
            Blob e = new Blob();

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
