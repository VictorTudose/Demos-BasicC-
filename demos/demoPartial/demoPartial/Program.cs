using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoPartial
{
    class Point
    {
        public int x;
        public int y;
        internal int z;
        public Point(int X,int Y,int Z)
        {
            this.x = X;
            this.y = Y;
            this.z = Z;
        }
        public void store(out int X,out int Y)
        {
            X = this.x;
            Y = this.y;
        }

        public void store(ref int X, ref int Y,ref int Z)
        {
            X = this.x;
            Y = this.y;
            Z = this.z;
        }

        public Point(string s)
        {
            string[] args = s.Split(new char[]{' '});
            this.x = int.Parse(args[0]);
            this.y = int.Parse(args[1]);
            this.z = int.Parse(args[2]);
        }

        public override string ToString() {
            return x.ToString() + " " +
                y.ToString() + " " +
                z.ToString();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Point p = new Point(3,4,7);
            Point q = new Point("2 231 1");
            
            int x, y;

            Console.WriteLine(p);
            Console.WriteLine(q);

            q.store(out x,out y);

            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.ReadKey(); 
        }
    }
}
