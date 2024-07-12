class Prac1d_3
{
	public static void Main(string[] args)
	{
	    System.Console.Write("Enter a Character:");
	    char ch = char.Parse(System.Console.ReadLine().ToLower());
	    if ("aeiou".IndexOf(ch) >= 0)
	    {
	        System.Console.WriteLine(ch + " is a vowel");
	    }
	    else
	    {
	        System.Console.WriteLine(ch + " is not a vowel");
	    }
	}
}