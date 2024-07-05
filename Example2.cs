using System;

class Demo
{   
    public string a = "hello"; 
}

class Example2
{
    string b = "World"; 

    public static void Main(string[] args)
    {
        Demo a = new Demo();
        System.Console.Write(a.a); 
        Example2 example = new Example2(); 
        System.Console.Write(example.b); 
    }
}
