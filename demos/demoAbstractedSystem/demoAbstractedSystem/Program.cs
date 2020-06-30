using System;

namespace demoAbstractedSystem
{

    class PresentationSystem
    {
        int time = 0;
        PresentationRoom[] presentations;
        public PresentationSystem(PresentationRoom[] presentations)
        {
            this.presentations = presentations;
        }

        public void Room_on(int n)
        {
            time++;
            presentations[n].on();
        }
        public void Room_off(int n)
        {
            time++;
            presentations[n].off();
        }

        public void Interogate()
        {
            Console.WriteLine("At time "+ time.ToString());
            for (int i = 0; i < presentations.Length; i++)
                Console.WriteLine(presentations[i]);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PresentationSystem presentation = new PresentationSystem(new PresentationRoom[] {
                    new PresentationRoom(),
                    new PresentationRoom(),
                    new PresentationRoom(),
                    new PresentationRoom(),
            });

            presentation.Room_on(1);
            presentation.Room_on(2);
            presentation.Room_on(3);
            presentation.Interogate();
            presentation.Room_off(2);
            presentation.Room_off(3);
            presentation.Interogate();

            Console.ReadKey();
        }
    }
}
