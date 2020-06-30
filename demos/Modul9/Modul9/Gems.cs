using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9
{
    class DexterityGem : Gem
    {
        public override void apply(Hero owner)
        {
            base.apply(owner);
            owner.dexterity += 10;
        }
        public override void unapply()
        {
            owner.dexterity -= 10;
        }
    }

    class IntelligenceGem : Gem
    {
        public override void apply(Hero owner)
        {
            base.apply(owner);
            owner.intelligence += 10;
        }
        public override void unapply()
        {
            owner.intelligence -= 10;
        }
    }

    partial class StrengthGem : Gem
    {
        public override void apply(Hero owner)
        {
            base.apply(owner);
            owner.strength += 10;
        }
        public override void unapply()
        {
            owner.strength -= 10;
        }

        public void meHere2()
        {
            Console.WriteLine("Me here2");
        }
    }

    partial class StrengthGem : Gem
    {
        public void meHere()
        {
            Console.WriteLine("Me here");
        }
    }

    class LeapSlam : StrengthGem
    {
        public override void apply(Hero owner)
        {
            base.apply(owner);
            owner.x += 10;
            owner.y += 20;
        }
    }
}
