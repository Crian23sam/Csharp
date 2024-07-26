class Casting
{
	public void Demo()
	{
		float sum;
		int i;
		sum=0.0F;
		for(i=1;i<=10;i++)
		{
			sum=sum+1/(float)i;
			System.Console.Write("i= "+i);
			System.Console.WriteLine(" Sum="+sum);
		}
	}
}

class MainCast
{
	public static void Main()
	{
		Casting obj=new Casting();
		obj.Demo();
	}
}