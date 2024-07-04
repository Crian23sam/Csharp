using System;

public class Bsum
{
    public static void Main(string[] args)
    {
        byte b1 = 100;
        byte b2 = 200;
        int sum = b1 + b2;
        byte b3 = (byte)sum;
        Console.WriteLine("sum={0}",b3);
    }
}