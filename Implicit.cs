class Implicit
{
    static void Main()
    {
        int intValue = 123;
        double doubleValue = intValue;
        System.Console.WriteLine("Implicitly converted int to double: " + doubleValue);

        short shortValue = 12345;
        long longValue = shortValue;
        System.Console.WriteLine("Implicitly converted short to long: " + longValue);

        byte byteValue = 200;
        float floatValue = byteValue;
        System.Console.WriteLine("Implicitly converted byte to float: " + floatValue);

        float anotherFloatValue = 123.45F;
        double anotherDoubleValue = anotherFloatValue;
        System.Console.WriteLine("Implicitly converted float to double: " + anotherDoubleValue);

        int anotherIntValue = 123456789;
        long anotherLongValue = anotherIntValue;
        System.Console.WriteLine("Implicitly converted int to long: " + anotherLongValue);

        long yetAnotherLongValue = 1234567890123456789;
        decimal decimalValue = yetAnotherLongValue;
        System.Console.WriteLine("Implicitly converted long to decimal: " + decimalValue);

        char charValue = 'A';
        int charToIntValue = charValue;
        System.Console.WriteLine("Implicitly converted char to int: " + charToIntValue);

        ushort ushortValue = 65535;
        uint uintValue = ushortValue;
        System.Console.WriteLine("Implicitly converted ushort to uint: " + uintValue);

        uint anotherUintValue = 1234567890;
        ulong ulongValue = anotherUintValue;
        System.Console.WriteLine("Implicitly converted uint to ulong: " + ulongValue);

        decimal anotherDecimalValue = 123456.78M;
        double decimalToDoubleValue = (double)anotherDecimalValue;
        System.Console.WriteLine("Implicitly converted decimal to double: " + decimalToDoubleValue);

        int nativeIntValue = 123;
        nint nintValue = nativeIntValue;
        System.Console.WriteLine("Implicitly converted int to nint: " + nintValue);

        uint nativeUnsignedIntValue = 123;
        nuint nuintValue = nativeUnsignedIntValue;
        System.Console.WriteLine("Implicitly converted uint to nuint: " + nuintValue);
    }
}
