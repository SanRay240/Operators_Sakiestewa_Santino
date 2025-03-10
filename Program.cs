using System;

namespace Operators_Sakiestewa_Santino
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializes an integer that multiplies two integers
            int intMult = 6 * 45;
            // Initiliazed an integer that adds to integers
            int intAdd = 55 + 66;
            // Prints the maximum and minimum of the two integer variables
            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}. " +
                $"The min of the two is {Math.Min(intMult, intAdd)}.");

            // Initializes boolean to see if intMult is greater than intAdd
            bool isintGreater = intMult > intAdd;
            // Prints if intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isintGreater}.");

            // Initializes an short that multiplies two short
            short shortMult = 6 * 45;
            // Initiliazed an short that adds to short
            short shortAdd = 55 + 66;
            // Prints the maximum and minimum of the two short variables
            Console.WriteLine($"The max of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}. " +
                $"The min of the two is {Math.Min(shortMult, shortAdd)}.");

            // Initializes boolean to see if shortMult is greater than shortAdd
            bool isshortGreater = shortMult > shortAdd;
            // Prints if shortMult is greater than shortAdd
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}.");

            // Initializes an long that multiplies two long
            long longMult = 6 * 45;
            // Initiliazed an long that adds to long
            long longAdd = 55 + 66;
            // Prints the maximum and minimum of the two long variables
            Console.WriteLine($"The max of {longMult} and {longAdd} is {Math.Max(longMult, longAdd)}. " +
                $"The min of the two is {Math.Min(longMult, longAdd)}.");

            // Initializes boolean to see if longMult is greater than longAdd
            bool islongGreater = longMult > longAdd;
            // Prlongs if longMult is greater than longAdd
            Console.WriteLine($"{longMult} is greater than {longAdd}, {islongGreater}.");

            // Initializes an float that multiplies two float
            float floatMult = 6.5f * 45.24f;
            // Initiliazed an float that adds to float
            float floatAdd = 55.35f + 66.15f;
            // Prints the maximum and minimum of the two float variables
            Console.WriteLine($"The max of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}. " +
                $"The min of the two is {Math.Min(floatMult, floatAdd)}.");

            // Initializes boolean to see if floatMult is greater than floatAdd
            bool isfloatGreater = floatMult > floatAdd;
            // Prints if floatMult is greater than floatAdd
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}.");

            // Initializes an double that multiplies two double
            double doubleMult = 6.69 * 45.58;
            // Initiliazed an double that adds to double
            double doubleAdd = 55.48 + 66.15;
            // Prints the maximum and minimum of the two double variables
            Console.WriteLine($"The max of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, doubleAdd)}. " +
                $"The min of the two is {Math.Min(doubleMult, doubleAdd)}.");

            // Initializes boolean to see if doubleMult is greater than doubleAdd
            bool isdoubleGreater = doubleMult > doubleAdd;
            // Prdoubles if doubleMult is greater than doubleAdd
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isdoubleGreater}.");

            // Initializes an decimal that multiplies two decimal
            decimal decimalMult = (decimal)(6.25 * 45.15);
            // Initiliazed an decimal that adds to decimal
            decimal decimalAdd = (decimal)(55.66 + 66.55);
            // Prints the maximum and minimum of the two decimal variables
            Console.WriteLine($"The max of {decimalMult} and {decimalAdd} is {Math.Max(decimalMult, decimalAdd)}. " +
                $"The min of the two is {Math.Min(decimalMult, decimalAdd)}.");

            // Initializes boolean to see if decimalMult is greater than decimalAdd
            bool isdecimalGreater = decimalMult > decimalAdd;
            // Prdecimals if decimalMult is greater than decimalAdd
            Console.WriteLine($"{decimalMult} is greater than {decimalAdd}, {isdecimalGreater}.");
        }
    }
}