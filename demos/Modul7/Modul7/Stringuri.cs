using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7
{
    class Stringuri
    {
        public static void demo()
        {
            Console.WriteLine("Demo stringuri");
            Console.WriteLine("--------------------------------");

            string sa = "ana";
            string sb = sa;
            sa = sa + " are mere";

            Console.WriteLine(sa);
            Console.WriteLine(sb);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
