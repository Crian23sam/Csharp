class Prac1d_2
{
	public static void Main(string[] args)
	{
	    System.Console.Write("Enter a number:");
	    int num = int.Parse(System.Console.ReadLine());
	    bool isPrime = true;

	    if (num <= 1)
	    {
	        isPrime = false;
	    }
	    else
	    {
	        for (int i = 2; i <= System.Math.Sqrt(num); i++)
	        {
	            if (num % i == 0)
	            {
	                isPrime = false;
	                break;
	            }
	        }
	    }

	    if (isPrime)
	    {
	        System.Console.WriteLine(num + " is a prime number");
	    }
	    else
	    {
	        System.Console.WriteLine(num + " is not a prime number");
	    }
	}
}