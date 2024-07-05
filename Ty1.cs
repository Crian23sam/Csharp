class Ty1
{
	public static void Main(string[] args)
	{
		int a = 10;
		object obj=(object)a;
		System.Console.WriteLine(obj);

		int b=20;
		object ob2=b;

		int c=(int)ob2;

		System.Console.WriteLine(ob2);
		System.Console.WriteLine(c);

	
	}
}