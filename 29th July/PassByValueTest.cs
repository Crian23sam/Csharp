class PassByValue
{
	static void Change(int m)
	{
		m=m+10;
	}
	
	void demo()
	{
		int x=100;
		Change(x);
		System.Console.WriteLine("x="+x);
	}
}

class PassByValueTest
{
	public static void Main()
	{
		PassByValue obj=new PassByValue();
		obj.demo();
	}
}

