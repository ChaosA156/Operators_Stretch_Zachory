using System;

namespace Operators_Stretch_Zachory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializes an integer that multiplies two integers
            int intMult = -3 * 53;
            // Initializes an integer that adds two integers
            int intAdd = 35 + 3;
            // Prints the maximum and minimum of the two integer variables
            Console.WriteLine($"the max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}." +
                $"The min of the two is {Math.Min(intMult, intAdd)}.");

            // Initializes boolean to see if intMult is greater than intAdd
            bool isIntGreater = intMult > intAdd;
            // Prints if intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.");

            
            // Initializes an shorteger that multiplies two shortegers
            short shortMult = 651 * 12;
            // Initializes an shorteger that adds two shortegers
            short shortAdd = 64 + 1;
            // Prints the maximum and minimum of the two shorteger variables
            Console.WriteLine($"the max of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}." +
                $"The min of the two is {Math.Min(shortMult, shortAdd)}.");

            // Initializes boolean to see if shortMult is greater than shortAdd
            bool isShortGreater = shortMult > shortAdd;
            // Prints if shortMult is greater than shortAdd
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isShortGreater}.");


            // Initializes an longeger that multiplies two longegers
            long longMult = 561 * 171;
            // Initializes an longeger that adds two longegers
            long longAdd = 23 + 5;
            // Prints the maximum and minimum of the two longeger variables
            Console.WriteLine($"the max of {longMult} and {longAdd} is {Math.Max(longMult, longAdd)}." +
                $"The min of the two is {Math.Min(longMult, longAdd)}.");

            // Initializes boolean to see if longMult is greater than longAdd
            bool isLongGreater = longMult > longAdd;
            // Prints if longMult is greater than longAdd
            Console.WriteLine($"{longMult} is greater than {longAdd}, {isLongGreater}.");


            // Initializes an floateger that multiplies two floategers
            float floatMult = 15 * 11;
            // Initializes an floateger that adds two floategers
            float floatAdd = 12 + 3;
            // Prints the maximum and minimum of the two floateger variables
            Console.WriteLine($"the max of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}." +
                $"The min of the two is {Math.Min(floatMult, floatAdd)}.");

            // Initializes boolean to see if floatMult is greater than floatAdd
            bool isFloatGreater = floatMult > floatAdd;
            // Prints if floatMult is greater than floatAdd
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isFloatGreater}.");


            // Initializes an doubleeger that multiplies two doubleegers
            double doubleMult = 651 * 711;
            // Initializes an doubleeger that adds two doubleegers
            double doubleAdd = 17 + 100;
            // Prints the maximum and minimum of the two doubleeger variables
            Console.WriteLine($"the max of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, doubleAdd)}." +
                $"The min of the two is {Math.Min(doubleMult, doubleAdd)}.");

            // Initializes boolean to see if doubleMult is greater than doubleAdd
            bool isDoubleGreater = doubleMult > doubleAdd;
            // Prints if doubleMult is greater than doubleAdd
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isDoubleGreater}.");


            // Initializes an decimaleger that multiplies two decimalegers
            decimal decimalMult = 165 * 419;
            // Initializes an decimaleger that adds two decimalegers
            decimal decimalAdd = 15 + 11;
            // Prints the maximum and minimum of the two decimaleger variables
            Console.WriteLine($"the max of {decimalMult} and {decimalAdd} is {Math.Max(decimalMult, decimalAdd)}." +
                $"The min of the two is {Math.Min(decimalMult, decimalAdd)}.");

            // Initializes boolean to see if decimalMult is greater than decimalAdd
            bool isDecimalGreater = decimalMult > decimalAdd;
            // Prints if decimalMult is greater than decimalAdd
            Console.WriteLine($"{decimalMult} is greater than {decimalAdd}, {isDecimalGreater}.");
        }
    }
}
