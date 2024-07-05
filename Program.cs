using System;

class Program
{
    static void Main()
    {
        // Example string containing a number
        string numberString = "123";

        try
        {
            // Using int.Parse to convert string to int
            int number = int.Parse(numberString);

            // Output the parsed integer
            Console.WriteLine("Parsed number: " + number);
        }
        catch (FormatException e)
        {
            // Catching FormatException in case of invalid format
            Console.WriteLine("Unable to parse. Format exception: " + e.Message);
        }
        catch (OverflowException e)
        {
            // Catching OverflowException in case of number too large or small for int
            Console.WriteLine("Unable to parse. Overflow exception: " + e.Message);
        }
        catch (Exception e)
        {
            // Catching any other unexpected exceptions
            Console.WriteLine("Unable to parse. Exception occurred: " + e.Message);
        }
    }
}