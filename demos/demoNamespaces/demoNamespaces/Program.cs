using System;

namespace AllToLeft
{
    class Utils
    {
        public static void move(ref int x, ref int y)
        {
            x--;
        }
    }
}

namespace demoNamespaces
{
    class Utils
    {
        public static void move(ref int x, ref int y)
        {
            y--;
        }
    }

    class Point
    {
        public int x;
        public int y;
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return x.ToString()+" "+y.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(2,3);
            Utils.move(ref A.x, ref A.y);
            Console.WriteLine( A );
            AllToLeft.Utils.move(ref A.x, ref A.y);
            Console.WriteLine(A );

            Console.ReadKey();

        }
    }
}
