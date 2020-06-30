using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9
{
    
        abstract class Move
        {
            public abstract bool throughWater();
            public abstract bool throughAir();
            public abstract bool throughLand();
            public abstract void move();
        }

        class MovingBehaviour
        {
            Move[] moves=new Move[3];

            public MovingBehaviour(string s)
            {
                if (s.IndexOf("fly") != -1)
                    moves[0] = new Fly();
                if (s.IndexOf("walk") != -1)
                    moves[1] = new Walk();
                if (s.IndexOf("swim") != -1)
                    moves[2]= new Swim();
            }

            public bool throughLand()
            {
                bool res = false;
                for (int i = 0; i < 3; i++)
                    if (moves[i] != null)
                        res |= moves[i].throughLand();
                return res;
            }

            public bool throughAir()
            {
                bool res = false;
                for (int i = 0; i < 3; i++)
                    if (moves[i] != null)
                        res |= moves[i].throughAir();
                return res;
            }

            public bool throughWater()
            {
                bool res = false;
                for (int i = 0; i < 3; i++)
                    if (moves[i] != null)
                        res |= moves[i].throughWater();
                return res;
            }

            public override string ToString()
            {
                return "Air " + throughAir() + "\nWater " + throughWater()+"\nLand "+throughLand() ;
            }
        }

    class SeparareComportament
    {
        public static void demo()
        {
            Hero h1= new Hero("fly");
            Console.WriteLine(h1.moving);
            Console.ReadKey();

            Hero h2 = new Hero("fly swim");
            Console.WriteLine(h2.moving);

            Console.ReadKey();
        }
    }
}
