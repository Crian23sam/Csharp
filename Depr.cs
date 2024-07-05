class Depr
{
	public static void Main(string[] args)
	{
		double p=System.Convert.ToDouble(args[0]);	
		double y=System.Convert.ToDouble(args[1]);
		double s=System.Convert.ToDouble(args[2]);

		double d=(p-s)/y;

		System.Console.WriteLine("{0}",d);
	}
}