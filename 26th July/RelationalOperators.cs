class RelationalOperators
{
	public void Demo()
	{
		float a=15.0F,b=20.75F,c=15.0F;
		Console.WriteLine("a="+a);
		Console.WriteLine("b="+b);
		Console.WriteLine("c="+c);
		Console.WriteLine("a<b is"+(a<b));
		Console.WriteLine("a>b is"+(a>b));
		Console.WriteLine("a==c is"+(a==c));
		Console.WriteLine("a<=c is"+(a<=c));
		Console.WriteLine("a>=b is"+(a>=b));
		Console.WriteLine("b !=c is"+(b!=c));
		Console.WriteLine("b==a+c is"+(b==a+c));
	}
}

class MainRelationalOperators
{
	public static void Main()
	{
		RelationalOperators obj=new RelationalOperators();
		obj.Demo();
	}
}