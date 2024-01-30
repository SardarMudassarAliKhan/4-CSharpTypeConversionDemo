using System;

namespace TypeConversionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion
            int myInt = 10;
            double myDouble = myInt; // Implicit conversion from int to double
            Console.WriteLine("Implicit Conversion: int to double");
            Console.WriteLine($"Original integer value: {myInt}");
            Console.WriteLine($"Converted double value: {myDouble}");
            Console.WriteLine();

            // Explicit Conversion (Casting)
            double anotherDouble = 10.5;
            int anotherInt = (int)anotherDouble; // Explicit conversion (cast) from double to int
            Console.WriteLine("Explicit Conversion (Casting): double to int");
            Console.WriteLine($"Original double value: {anotherDouble}");
            Console.WriteLine($"Converted int value: {anotherInt}");
            Console.WriteLine();

            // Conversion Methods
            int number = 20;
            string numberString = number.ToString(); // Convert int to string using ToString() method
            Console.WriteLine("Conversion Methods: int to string");
            Console.WriteLine($"Original int value: {number}");
            Console.WriteLine($"Converted string value: {numberString}");
            Console.WriteLine();

            string priceString = "15.75";
            double price = double.Parse(priceString); // Convert string to double using Parse() method
            Console.WriteLine("Conversion Methods: string to double");
            Console.WriteLine($"Original string value: {priceString}");
            Console.WriteLine($"Converted double value: {price}");
            Console.WriteLine();

            // Convert Class
            int anotherIntValue = 30;
            double anotherDoubleValue = Convert.ToDouble(anotherIntValue); // Convert int to double using Convert class
            Console.WriteLine("Convert Class: int to double");
            Console.WriteLine($"Original int value: {anotherIntValue}");
            Console.WriteLine($"Converted double value: {anotherDoubleValue}");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
