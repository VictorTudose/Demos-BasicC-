using System;

class Program
    {
        public class Complex
        {
            public int rez;
            public int imz;
            public Complex(int x,int y)
            {
                rez = x;
                imz = y;
            }
        }

        public static int abs(Complex z)
        {
            return z.rez * z.rez + z.imz * z.imz;
        }

        public static int abs(int x)
        {
            return x > 0 ? x : -x;
        }
	
	        public static int abs(long x)
        {
            return x > 0 ? (int)x : (int)-x;
        }
	
			public static int sum(int x,int y)
			{
				return x+y;
			}

	public static int sum(int x,int y,int z)
			{
				return x+y+z;
			}
	

	

        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine(abs(-3));
			Complex z = new Complex(2,3);
            Console.WriteLine(abs(z));
			
			Console.WriteLine(sum(-3,3));
			Console.WriteLine(sum(-3,3,3));
			


            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }