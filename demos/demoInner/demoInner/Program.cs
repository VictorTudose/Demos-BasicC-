using System;

namespace demoInner
{
    class Point
    {
        class Speed
        {
            Point point;
            public int x;
            public int y;
            public Speed(int x,int y,Point point)
            {
                this.x = x;
                this.y = y;
                this.point = point;
            }
            public void update()
            {
                if (point.x > 10 || point.x<=0)
                    x *= (-1);
                if (point.y > 10 || point.y <=0)
                    y *= (-1);
            }
        }

        public int x;
        public int y;
        Speed speed;
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
            speed = new Speed(x+2,y,this);
        }
        public void move()
        {
            x += speed.x;
            y += speed.y;
            speed.update();
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
            Point p = new Point(2, 3);
            for(int i=0;i<10;i++)
            {
                p.move();
                Console.WriteLine(p);
            }
            Console.ReadKey();
        }
    }
}
