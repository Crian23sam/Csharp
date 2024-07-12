class Prac1d_4
{
	public static void Main(string[] args)
	{
	   System.Console.WriteLine("Enter a number:");
	    int num = int.Parse(System.Console.ReadLine());
	    int reversedNum = 0, sumOfDigits = 0;

	    while (num != 0)
	    {
	        int digit = num % 10;
	        reversedNum = reversedNum * 10 + digit;
	        sumOfDigits += digit;
	        num /= 10;
	    }
	
	    System.Console.WriteLine("Reversed number: " + reversedNum);
	    System.Console.WriteLine("Sum of Digits: " + sumOfDigits);
	}
}