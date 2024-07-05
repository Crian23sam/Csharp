using System;

class Demo
{   
	 public double var1 = 5; 
	 public double var2=10;

}

class Example3
{
    double var3; 

    public static void Main(string[] args)
    {
        Demo a = new Demo();
        Example3 example = new Example3(); 
        example.var3=a.var1+a.var2;
	//System.Console.Write(a.var1+"+"+a.var2+"="+example.var3);
	System.Console.Write("{0}+{1}={2}", a.var1, a.var2, example.var3);
    }
}
