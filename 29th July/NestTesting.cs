class Nesting
{
	public void Largest(int m,int n)
	{
		int large=Max(m,n);
		System.Console.WriteLine(large);
	}
	public int Max(int a, int b)
	{
		int x =(a>b)?a:b;
	}
}

class NestTesting
{
	public static void Main()
	{
		Nesting next=new Nesting();
		next.Largest(100,200);
	}
}