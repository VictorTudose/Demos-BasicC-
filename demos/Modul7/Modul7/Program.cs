using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7
{

    class A
    {
        public int a;
        public A(int a)
        {
            this.a = a;
        }
    }

    class B : A
    {
        public int b;
        public B(int a,int b) : base(a)
        {
            this.b = b;
        }
    }

    class C { }

    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            Console.ReadKey();
            //Referinte.demo();
            //Stringuri.demo();
            //Referinte.demoConversii();
            //Referinte.demoBoxing();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
