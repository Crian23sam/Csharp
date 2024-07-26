using System;
class Casting
{
	public static void Main()
	{
		float sum;
		int i;
		sum=0.0F;
		for(i=1;i<=10;i++)
		{
			sum=sum+1/(float)i;
			System.Console.Write("i="+i);
			System.Console.WriteLine("Sum="+sum);
		}
	}
}