class FloatPoint
{
	public void Demo()
	{
		float a=20.5F,b=6.4F;
		System.Console.WriteLine("a="+a);
		System.Console.WriteLine("b="+b);
		System.Console.WriteLine("a+b="+(a+b));
		System.Console.WriteLine("a-b="+(a-b));
		System.Console.WriteLine("a*b="+(a*b));
		System.Console.WriteLine("a/b="+(a/b));
		System.Console.WriteLine("a%b="+(a%b));
	}
}

class MainFloatPoint
{
	public static void Main()
	{
		FloatPoint obj=new FloatPoint();
		obj.Demo();
	}
}