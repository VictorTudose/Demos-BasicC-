using System;

namespace Modul3
{
    public class Program
    {

        public enum Color { Red, Green, Blue};

        public struct Employee
        {
            public string firstName;
            public int age;
        }


        public static void Main(string[] args)
        {

            int integer = 1 << 30;
			Console.WriteLine("Initial integer: "+integer);
            long bigNumber = integer;
            Console.WriteLine("Implicitly casted long: "+bigNumber);
            bigNumber <<= 2;
            Console.WriteLine("New long: "+bigNumber);
            int second = (int)bigNumber;
           	Console.WriteLine("Explicitly casted integer: "+second);

			Console.WriteLine();
			
            Color fColor = Color.Red;
            Console.WriteLine("{0}", fColor);

            Color colorPalette = (Color)0;
            Console.WriteLine("{0}", colorPalette);

            colorPalette = (Color)((int)colorPalette + 1);
            Console.WriteLine("{0}", colorPalette);

        }
    }
}

