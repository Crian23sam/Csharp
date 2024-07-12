class Prac1d_1
{
	public static void Main(string[] args)
	{
		System.Console.Write("Enter a number:");
		int n = int.Parse(System.Console.ReadLine());
		int a = 0, b = 1, c;
		System.Console.Write("Fibonacci Series:" + a + " " + b + " ");
		for (int i = 2; i < n; i++)
		{
		        c = a + b;
		        System.Console.Write(c + " ");
		        a = b;
		        b = c;
		}
		System.Console.WriteLine();
	}
}