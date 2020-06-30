using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul8
{
    class A { }
    class B:A { }

    class Cont
    {
        public static int cursEuroRon;
        public int suma;

        private Cont()
        {
            suma = 3;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            int a=2;

            object b = a;

            B beta = new B();
            A alfa = beta;
            Console.WriteLine(beta is A) ;
            Console.WriteLine(alfa is B);

            Console.ReadKey();
        }
    }
}
