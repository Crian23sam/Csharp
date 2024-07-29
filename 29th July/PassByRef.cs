using System
class PassByRef
{
	static void Swap(ref int x,ref int y)
	{
		int temp = x;
		x = y;
		y = temp;
	}
	void Demo()
	{
		int m = 100;
		int n = 200;
		Console.WriteLine("Before Swapping");
		Console.WriteLine("m = " + m);
		Console.WriteLine("n = " + n);

		Swap( ref m, ref n);

		Console.WriteLine("After Swapping");
		Console.WriteLine("m = " + m);
		Console.WriteLine("n = " + n);
	}
}

class PassByRef
{
	public static void Main()
	{
		PassByRef d=new PassByRef();
		d.Demo();
	}
}