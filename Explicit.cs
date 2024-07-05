class Explicit
{
    static void Main()
    {
        int intValue = 1;
        bool boolValue = System.Convert.ToBoolean(intValue);
        System.Console.WriteLine("Explicitly converted int to bool: " + boolValue);

        int anotherIntValue = 255;
        byte byteValue = System.Convert.ToByte(anotherIntValue);
        System.Console.WriteLine("Explicitly converted int to byte: " + byteValue);

        int yetAnotherIntValue = -128;
        sbyte sbyteValue = System.Convert.ToSByte(yetAnotherIntValue);
        System.Console.WriteLine("Explicitly converted int to sbyte: " + sbyteValue);

        char charValue = 'A';
        int charToIntValue = System.Convert.ToInt32(charValue);
        System.Console.WriteLine("Explicitly converted char to int: " + charToIntValue);

        decimal decimalValue = 123.45M;
        int decimalToIntValue = System.Convert.ToInt32(decimalValue);
        System.Console.WriteLine("Explicitly converted decimal to int: " + decimalToIntValue);

        double doubleValue = 123.45;
        float doubleToFloatValue = System.Convert.ToSingle(doubleValue);
        System.Console.WriteLine("Explicitly converted double to float: " + doubleToFloatValue);

        double anotherDoubleValue = 123.45;
        int doubleToIntValue = System.Convert.ToInt32(anotherDoubleValue);
        System.Console.WriteLine("Explicitly converted double to int: " + doubleToIntValue);

        uint uintValue = 123;
        int uintToIntValue = System.Convert.ToInt32(uintValue);
        System.Console.WriteLine("Explicitly converted uint to int: " + uintToIntValue);

        int nintValue = 123;
        nint nintValueExplicit = System.Convert.ToInt32(nintValue);
        System.Console.WriteLine("Explicitly converted int to nint: " + nintValueExplicit);

        uint nuintValue = 123;
        nuint nuintValueExplicit = System.Convert.ToUInt32(nuintValue);
        System.Console.WriteLine("Explicitly converted uint to nuint: " + nuintValueExplicit);

        long longValue = 123456789;
        int longToIntValue = System.Convert.ToInt32(longValue);
        System.Console.WriteLine("Explicitly converted long to int: " + longToIntValue);

        ulong ulongValue = 123456789;
        uint ulongToUintValue = System.Convert.ToUInt32(ulongValue);
        System.Console.WriteLine("Explicitly converted ulong to uint: " + ulongToUintValue);

        short shortValue = 123;
        int shortToIntValue = System.Convert.ToInt32(shortValue);
        System.Console.WriteLine("Explicitly converted short to int: " + shortToIntValue);

        ushort ushortValue = 123;
        int ushortToIntValue = System.Convert.ToInt32(ushortValue);
        System.Console.WriteLine("Explicitly converted ushort to int: " + ushortToIntValue);
    }
}
