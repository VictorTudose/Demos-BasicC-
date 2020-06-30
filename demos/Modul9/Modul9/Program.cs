using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace Modul9
{
    delegate void say();

    public static class Extension
    {
        public static bool longerthan(this string str,int x)
        {
            return str.Length > x;
        }
       
    }

    class Program
    {

        
        
        static void Main(string[] args)
        {


            Console.WriteLine(Math.Sqrt(3));
            Console.WriteLine(new Random().Next(1,15));

            Console.ReadKey();
           
        }
    }
}
