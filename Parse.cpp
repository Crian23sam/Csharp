class Parse
{
    static void Main()
    {
        string boolString = "true";
        bool boolValue = bool.Parse(boolString);
        System.Console.WriteLine("Parsed boolean: " + boolValue);

        string byteString = "255";
        byte byteValue = byte.Parse(byteString);
        System.Console.WriteLine("Parsed byte: " + byteValue);

        string sbyteString = "127";
        sbyte sbyteValue = sbyte.Parse(sbyteString);
        System.Console.WriteLine("Parsed sbyte: " + sbyteValue);

        string charString = "A";
        char charValue = char.Parse(charString);
        System.Console.WriteLine("Parsed char: " + charValue);

        string decimalString = "123.45";
        decimal decimalValue = decimal.Parse(decimalString);
        System.Console.WriteLine("Parsed decimal: " + decimalValue);

        string doubleString = "123.45";
        double doubleValue = double.Parse(doubleString);
        System.Console.WriteLine("Parsed double: " + doubleValue);

        string floatString = "123.45";
        float floatValue = float.Parse(floatString);
        System.Console.WriteLine("Parsed float: " + floatValue);

        string intString = "123";
        int intValue = int.Parse(intString);
        System.Console.WriteLine("Parsed integer: " + intValue);

        string uintString = "123";
        uint uintValue = uint.Parse(uintString);
        System.Console.WriteLine("Parsed uint: " + uintValue);

        string nintString = "123";
        nint nintValue = int.Parse(nintString);
        System.Console.WriteLine("Parsed nint: " + nintValue);

        string nuintString = "123";
        nuint nuintValue = uint.Parse(nuintString);
        System.Console.WriteLine("Parsed nuint: " + nuintValue);

        string longString = "123456789";
        long longValue = long.Parse(longString);
        System.Console.WriteLine("Parsed long: " + longValue);

        string ulongString = "123456789";
        ulong ulongValue = ulong.Parse(ulongString);
        System.Console.WriteLine("Parsed ulong: " + ulongValue);

        string shortString = "123";
        short shortValue = short.Parse(shortString);
        System.Console.WriteLine("Parsed short: " + shortValue);

        string ushortString = "123";
        ushort ushortValue = ushort.Parse(ushortString);
        System.Console.WriteLine("Parsed ushort: " + ushortValue);
    }
}
