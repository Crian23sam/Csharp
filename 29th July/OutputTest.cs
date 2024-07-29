using System;
class Output
{
	public static void Square ( int x, out int y)
	{
		y = x * x;
	}
	void Demo()
	{
		int m;
		Square ( 10, out m);
		System.Console.WriteLine("m = " + m)
	}
}

class OutputTest
{
	publuc static void Main()
	{
		Output d=new Output();
		d.Demo();
	}
}