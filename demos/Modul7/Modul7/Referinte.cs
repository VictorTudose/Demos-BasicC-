using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7
{
    class Referinte
    {
        public static void demo()
        {
            Console.WriteLine("Demo referinte multiple");
            Console.WriteLine("--------------------------------");

            A a = new A(5);
            A b = a;
            A c = new A(7);
            A d = c;
            A e;
            A f;
            f = e = d;

            Console.WriteLine("A: " + a.a.ToString() + " C: " + c.a.ToString());
            Console.ReadKey();
            b.a = 6;
            Console.WriteLine("A: " + a.a.ToString() + " C: " + c.a.ToString());
            Console.ReadKey();
            c.a = b.a - 2;
            Console.WriteLine("A: " + a.a.ToString() + " C: " + c.a.ToString());
            Console.ReadKey();
            b.a = a.a + 2;
            d.a = e.a - 3;
            Console.WriteLine("A: " + a.a.ToString() + " C: " + c.a.ToString());
            Console.ReadKey();
            e.a = a.a + 3;
            Console.WriteLine("A: " + a.a.ToString() + " C: " + c.a.ToString());
            Console.ReadKey();
            f.a = c.a - 2;
            Console.WriteLine("A: " + a.a.ToString() + " C: " + c.a.ToString());
            Console.ReadKey();

            Console.WriteLine();
            Console.ReadKey();
        }
        public static void demoConversii()
        {
            Console.WriteLine("Demo conversii");
            Console.WriteLine("--------------------------------");

            B bb = new B(1, 3);
            A a1;
            if (bb is A)
            {
                a1 = (A)bb;
                a1.a = 5;
            }
            else
                a1 = (A)null;

            Console.WriteLine("a1: {a " + a1.a +"}");
            Console.WriteLine("bb: {a " + bb.a + " ," + bb.b + "}");

            A aa = bb as A;

            aa.a = 7;
            Console.WriteLine("bb: {a " + bb.a + " ," + bb.b + "}");

            Console.WriteLine();
            Console.ReadKey();
        }
        
        public static void demoBoxing()
        {
            Console.WriteLine("Demo boxing");
            Console.WriteLine("--------------------------------");

            int myint = 3;
            Object box = myint;
            Console.WriteLine("Boxed " + box);

            int second = (int)box;

            Console.WriteLine("Unboxed "+second);

            double e = 2.3;
            int e2;
            Object box2 = e;
            e2 = (int)(double)box2;
            Console.WriteLine("Second unboxed " + e2);

            Console.WriteLine();
            Console.ReadKey();
        }

    }
}
