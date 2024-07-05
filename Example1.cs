class Demo
{	
	public string a="hello";
}
class Example1
{
	string b="World";

	public static void Main(string[] args)
	{
		Demo a = new Demo();
		System.Console.WriteLine(a.a);

		Example1 example = new Example1(); 
       		System.Console.WriteLine(example.b);
	}
}