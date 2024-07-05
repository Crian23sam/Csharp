class Convert
{
    static void Main()
    {
        string boolString = "true";
        bool boolValue = System.Convert.ToBoolean(boolString);
        System.Console.WriteLine("Converted to boolean: " + boolValue);

        string byteString = "255";
        byte byteValue = System.Convert.ToByte(byteString);
        System.Console.WriteLine("Converted to byte: " + byteValue);

        string sbyteString = "127";
        sbyte sbyteValue = System.Convert.ToSByte(sbyteString);
        System.Console.WriteLine("Converted to sbyte: " + sbyteValue);

        string charString = "A";
        char charValue = System.Convert.ToChar(charString);
        System.Console.WriteLine("Converted to char: " + charValue);

        string decimalString = "123.45";
        decimal decimalValue = System.Convert.ToDecimal(decimalString);
        System.Console.WriteLine("Converted to decimal: " + decimalValue);

        string doubleString = "123.45";
        double doubleValue = System.Convert.ToDouble(doubleString);
        System.Console.WriteLine("Converted to double: " + doubleValue);

        string floatString = "123.45";
        float floatValue = System.Convert.ToSingle(floatString);
        System.Console.WriteLine("Converted to float: " + floatValue);

        string intString = "123";
        int intValue = System.Convert.ToInt32(intString);
        System.Console.WriteLine("Converted to int: " + intValue);

        string uintString = "123";
        uint uintValue = System.Convert.ToUInt32(uintString);
        System.Console.WriteLine("Converted to uint: " + uintValue);

        string nintString = "123";
        nint nintValue = System.Convert.ToInt32(nintString);
        System.Console.WriteLine("Converted to nint: " + nintValue);

        string nuintString = "123";
        nuint nuintValue = System.Convert.ToUInt32(nuintString);
        System.Console.WriteLine("Converted to nuint: " + nuintValue);

        string longString = "123456789";
        long longValue = System.Convert.ToInt64(longString);
        System.Console.WriteLine("Converted to long: " + longValue);

        string ulongString = "123456789";
        ulong ulongValue = System.Convert.ToUInt64(ulongString);
        System.Console.WriteLine("Converted to ulong: " + ulongValue);

        string shortString = "123";
        short shortValue = System.Convert.ToInt16(shortString);
        System.Console.WriteLine("Converted to short: " + shortValue);

        string ushortString = "123";
        ushort ushortValue = System.Convert.ToUInt16(ushortString);
        System.Console.WriteLine("Converted to ushort: " + ushortValue);
    }
}
