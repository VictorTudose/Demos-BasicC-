
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoInheritance
{
    abstract class Musician
    {
        public abstract void play();
    }

    class Violonist : Musician
    {
        public override void play()
        {
            Console.WriteLine("Violonist");
        }
    }

    class Pianist : Musician
    {
        public override void play()
        {
            Console.WriteLine("Pianist");
        }
    }

    class Guitarist: Musician
    {
        public override void play()
        {
            Console.WriteLine("Guitarist");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Musician[] musicians = new Musician[] { new Violonist(),
                                                 new Pianist() ,
                                                 new Guitarist(),
                                                 new Pianist()};

            foreach (Musician musician in musicians)
            {
                switch (musician)
                {
                    case Violonist V:
                        V.play();
                        break;
                    case Pianist P:
                        P.play();
                        break;
                    default:
                        Console.WriteLine("No valid type found");
                        break;
                }
            }

            Console.ReadKey();

        }
    }
}
