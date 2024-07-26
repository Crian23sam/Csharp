class IncrementOperator
{
	public static void Main()
	{
		int m=10,n=20;
		System.Console.WriteLine("m="+m);
		System.Console.WriteLine("n="+n);
		System.Console.WriteLine("++m="+ ++m);
		System.Console.WriteLine("n++="+ n++);
		System.Console.WriteLine("m="+m);
		System.Console.WriteLine("n="+n);
	}
}

class MainIncrementOperator
{
	public static void Main()
	{
		IncrementOperator obj=new IncrementOperator();
		obj.Demo();
	}
}