using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9
{
    interface IAttack
    {
        void attack();
    }

    class Soldat :Hero,IAttack
    {
        void IAttack.attack()
        {
            Console.WriteLine("Soldat");
        }
    }
    
    class General
    {
        IAttack[] units;
        int index;
        public void add(IAttack to_add)
        {
            units[index++] = to_add;
        }

        public int totalDex()
        {
            int res = 0;
            for (int i = 0; i < index; i++)
                if (units[i] is Hero)
                    res += ((Hero)units[i]).dexterity;
            return res;
        }
        public int totalStrength()
        {
            int res = 0;
            for (int i = 0; i < index; i++)
                if (units[i] is Hero)
                    res += ((Hero)units[i]).strength;
            return res;
        }
        public int totalIntellice()
        {
            int res = 0;
            for (int i = 0; i < index; i++)
                if (units[i] is Hero)
                    res += ((Hero)units[i]).intelligence;
            return res/index;
        }

        public override string ToString()
        {
            return "Strength "+totalStrength()+"\nDexterity "+totalDex()
                +"\nIntelligence "+totalIntellice() ;
        }

        public General()
        {
            units = new IAttack[10];
        }
    }

    class Refolosire
    {
        public static void demo()
        {
            General mygeneral = new General();

            mygeneral.add(new Soldat());
            mygeneral.add(new Soldat());

            Soldat trickyOne = new Soldat(); ;

            trickyOne.collect(new DexterityGem());
            trickyOne.collect(new DexterityGem());
            mygeneral.add(trickyOne);

            Console.WriteLine(mygeneral);

            Console.ReadKey();
            trickyOne.collect(new IntelligenceGem());
            Console.WriteLine(mygeneral);

            Console.ReadKey();
        }
    }
}
