using System;
class Params
{
	static void Parray ( params int [] arr)
	{
		Console.Write("Array elements are:");
		foreach (int i in arr)
			Console.Write(" " + i);
		Console.WriteLine();
	}
	void Demo()
	{ 
		int [] x = { 11,22,33 };
		Parray (x);
		Parray ();
		Parray (100,200);
	}
}

class ParamsTest
{
	public static void Main()
	{
		Params d=new Params();
		d.Demo();
	}
}
