
using System;

public class Sum
{
    public static void Main(string[] args)
    {
        int m = 100;
        long n = 200;
      //int l = m + n; Cannot implicitly convert type 'long' to 'int'. An explicit conversion exists (are you missing a cast?)
        long l = m + n; //provides correct o/p
        int l1 = (int)l;//if we comment this line still the code will provide correct o/p
        Console.WriteLine(l1);
    }
}
