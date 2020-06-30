using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9
{

    class Walk : Move
    {
        public override bool throughWater()
        {
            return false;
        }
        public override bool throughAir()
        {
            return false;
        }
        public override bool throughLand()
        {
            return false;
        }
        public override void move()
        {
            Console.WriteLine("I'm walking");
        }
    }

    class Fly : Move
    {
        public override bool throughWater()
        {
            return false;
        }
        public override bool throughAir()
        {
            return true;
        }
        public override bool throughLand()
        {
            return true;
        }
        public override void move()
        {
            Console.WriteLine("I'm flying");
        }
    }

    class Swim : Move
    {
        public override bool throughWater()
        {
            return true;
        }
        public override bool throughAir()
        {
            return false;
        }
        public override bool throughLand()
        {
            return false;
        }
        public override void move()
        {
            Console.WriteLine("I'm swiming");
        }
    }
}
