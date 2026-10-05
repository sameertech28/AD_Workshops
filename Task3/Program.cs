class Program
{
    static void Main()
    {
        byte byteValue = 255;
        short shortValue = 32000;
        int intValue = 42;
        long longValue = 9000000000L;
        float floatValue = 8.10f;
        double doubleValue = 3.14159;
        decimal decimalValue = 123.45m;
        char charValue = 'A';
        bool boolValue = true;
        string stringValue = "3.14";

        string convertedInt = intValue.ToString();
        double convertedstring = Convert.ToDouble(stringValue);
        
        Console.WriteLine($"byte: {byteValue}");
        Console.WriteLine($"short: {shortValue}");
        Console.WriteLine($"int: {intValue}");
        Console.WriteLine($"long: {longValue}");
        Console.WriteLine($"float: {floatValue}");
        Console.WriteLine($"double: {doubleValue}");
        Console.WriteLine($"decimal: {decimalValue}");
        Console.WriteLine($"char: {charValue}");
        Console.WriteLine($"bool: {boolValue}");
        Console.WriteLine($"Converted int to string: {convertedInt}");
        Console.WriteLine($"Converted String to double: {convertedstring}");
        
    }
}