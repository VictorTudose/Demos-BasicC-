using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9
{

    class MyTime
    {
        public int passed;
        public static MyTime instance;
        IhasTTL[] ihasTTLs;
        public int index;

        private MyTime()
        {
            instance = this;
            passed = 0;
            ihasTTLs = new IhasTTL[10];
        }
        public static MyTime getInstance()
        {
            if (instance == null)
                instance = new MyTime();
            return instance;
        }

        public void add(IhasTTL to_add)
        {
            ihasTTLs[index++] = to_add;
        }

        public void remove(IhasTTL to_add)
        {
            for(int i=0;i<index;i++)
                if(ihasTTLs[i]==to_add)
                {
                    for (int j = i; j < index - 1; j++)
                        ihasTTLs[j] = ihasTTLs[j + 1];
                    index--;
                    return;
                }
        }

        public void tick()
        {
            passed++;
            for (int i = 0; i < index; i++)
                ihasTTLs[i].check();
        }
    }

    interface IhasTTL
    {
        void check();
    }

    abstract class Gem : IDisposable , IhasTTL
    {
        protected string color;
        protected int ttl=0;
        protected int start;
        protected Hero owner;
        public virtual void apply(Hero owner)
        {
            this.owner = owner;
        }
        public abstract void unapply();

        public void Dispose()
        {
            unapply();
        }

        public void check()
        {
            if (MyTime.getInstance().passed - start >= ttl)
            {
                Dispose();
                MyTime.getInstance().remove(this);
            }
        }

        public Gem()
        {
            start = MyTime.getInstance().passed;
            ttl = 3;
            MyTime.getInstance().add(this);
        }

    }
    class Hero
    {
        public int dexterity;
        public int intelligence;
        public int strength;
        public int x;
        public int y;
        public MovingBehaviour moving;

        public Hero()
        {
            dexterity = 10;
            intelligence = 10;
            strength = 10;
            x = 0;
            y = 0;
            moving = null;
        }
        public Hero(string s) : this()
        {            
            moving = new MovingBehaviour(s);
        }

        public void collect(Gem gem)
        {
            gem.apply(this);
            MyTime.getInstance().tick();
        }

        public override string ToString()
        {
            return "pos :{"+x+" "+y+"} stats:{ Dex:"+dexterity+" Str:"+strength+" Int:"+intelligence+"}";
        }

    }

    class InterfeteSiClaseAbstracte
    {

        public static void demo()
        {
            Console.ReadKey();

            Hero h = new Hero();

            h.collect(new DexterityGem());
            h.collect(new IntelligenceGem());
            Console.WriteLine(h);
            Console.ReadKey();


            h.collect(new StrengthGem());
            h.collect(new LeapSlam());

            Console.WriteLine(h);
            Console.ReadKey();
            MyTime.getInstance().tick();

            Console.WriteLine(h);
            Console.ReadKey();
            MyTime.getInstance().tick();

            Console.WriteLine(h);
            Console.ReadKey();

            h.collect(new IntelligenceGem());
            h.collect(new StrengthGem());

            Console.WriteLine(h);
            Console.ReadKey();

            MyTime.getInstance().tick();
            MyTime.getInstance().tick();

            Console.WriteLine(h);

            Console.ReadKey();

        }
    }
}
