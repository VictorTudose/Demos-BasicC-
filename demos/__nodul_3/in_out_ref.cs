using System;

class RefDemo
    {
        public static void OutFunc(out int x)
        {
            x = 32;
			
        }
	
	
        public static void Swap(ref int x,ref int y)
        {
            x += y;
            y = x - y;
            x -= y;
        }
		
		// "in" este disponibil incepand cu C# 7.2 sau mai nou
		public static void doSmth(in int x)
		{
			
		}

}

public class Program
{
	
	public static void Main()
	{
		Console.WriteLine("Hello World");
		int x,y;
		ReffyBoy.OutFunc(out x);
		ReffyBoy.OutFunc(out y);
		y++;
		ReffyBoy.Swap(ref x,ref y);
		Console.WriteLine("x="+x.ToString());
		Console.WriteLine("y="+y.ToString());
		
	}
}