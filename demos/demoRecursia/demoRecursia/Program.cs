using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoRecursia
{
    class Program
    {

        public static int factorial(int n)
        {
            if (n == 1)
                return 1;
            return n * factorial(n - 1);
        }

        public static void recDisp(int[] n,int i)
        {
            if (i > n.Length - 1)
                return;
            Console.Write(n[i]+" ");
            recDisp(n, i + 1);
        }

        public static void recRevDisp(int[] n, int i)
        {
            if (i > n.Length - 1)
                return;
            recRevDisp(n, i + 1);
            Console.Write(n[i]+" ");
        }

        static void Main(string[] args)
        {
            recDisp(new int[] { 1, 2, 3, 4 }, 0);

            // recDisp({1,2,3,4},0)


            // Console.Write(0)
            // recDisp({1,2,3,4},1)

            // Console.Write(0)
            // Console.Write(1)
            // recDisp({1,2,3,4},2)

            // Console.Write(0)
            // Console.Write(1)
            // Console.Write(2)
            // recDisp({1,2,3,4},3)

            // Console.Write(0)
            // Console.Write(1)
            // Console.Write(2)
            // Console.Write(3)
            // return ;


            Console.WriteLine();
            recRevDisp(new int[] { 1, 2, 3, 4 }, 0);

            // recRevDisp({1,2,3,4},0)

            // recRevDisp({1,2,3,4},1)
            // Console.Write(0)

            // recRevDisp({1,2,3,4},2)
            // Console.Write(1)
            // Console.Write(0)

            Console.ReadKey();

        }
    }
}
