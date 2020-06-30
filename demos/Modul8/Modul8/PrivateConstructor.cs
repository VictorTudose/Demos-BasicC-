using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul8
{
    class Unique
    {
        static bool a;
        public static Unique getInstrance()
        {
            if(!a)
            {
                a = true;
                return new Unique();
            }
            return null;
        }

        private Unique() { }
    }

    class PrivateConstructor
    {
       public static void demo()
        {

            Console.WriteLine("Demo constructori privati");
            Console.WriteLine("--------------------------------");
            Unique theOneAndOnly = Unique.getInstrance();
            Unique fake1 = Unique.getInstrance();
            Unique fake2 = Unique.getInstrance();

            Console.WriteLine(theOneAndOnly != null? "Not null":"Null"  );
            Console.WriteLine(fake1 != null ? "Not null" : "Null");
            Console.WriteLine(fake2 != null ? "Not null" : "Null");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
