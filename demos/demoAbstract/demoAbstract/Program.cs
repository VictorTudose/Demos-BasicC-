using System;

namespace demoAbstract
{

    class AbstractedObject
    {
        public static int count=0;
        public static AbstractedObject lastCreated = null;
        public static AbstractedObject firstCreated = null;
        int id;
        public AbstractedObject()
        {
            count++;
            id = count;
            if (firstCreated == null)
                firstCreated = this;
            lastCreated = this;
        }
        public override string ToString()
        {
            return id.ToString();
        }
    }

    class NotSoAbstractObject
    {
        public static int count = 0;
        int id;
        public NotSoAbstractObject()
        {
            count++;
            id = count;
        }
        public override string ToString()
        {
            return id.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
                new AbstractedObject();
            
            Console.WriteLine(AbstractedObject.lastCreated);
            Console.WriteLine(AbstractedObject.firstCreated);

            NotSoAbstractObject[] array = { new NotSoAbstractObject(),
                                            new NotSoAbstractObject(),
                                            new NotSoAbstractObject(),
                                            new NotSoAbstractObject(),
                                            new NotSoAbstractObject()
                                          };

            Console.WriteLine(array[0]);
            Console.WriteLine(array[array.Length-1]);

            Console.ReadKey();

        }
    }
}
