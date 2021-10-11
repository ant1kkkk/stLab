using System;

namespace Ex01
{
    class Program
    {
        static int Increment(int variable) // Method that executing prefix the increment operation
        {
            return ++variable;
        }
        static int Decrement(int variable) // Method that executing prefix the decrement operation
        {
            return --variable;
        }
        static double MultiplicationAndDivision(int firstVariable, int secondVariable) // Methot that executing the multiplication and the division operations
        {
            return (firstVariable * secondVariable) / firstVariable;
        }
        static int Remainder(int firstVariable, int secondVariable) // Methot that returns the remainder operation
        {
            return Math.Abs(firstVariable % secondVariable);
        }
        static bool LogicalOperand()
        {
            Console.WriteLine("Logical Operand");  
            return true;
        }
        static void ConditionalConjunction(bool firstVariable, bool secondVariable)
        {
            firstVariable = firstVariable && LogicalOperand();
            Console.WriteLine($"\n{firstVariable}");
            secondVariable = secondVariable && LogicalOperand();
            Console.WriteLine($"\n{secondVariable}");
        }
        static void ConditionalDisjunction (bool firstVariable, bool secondVariable)
        {
            firstVariable =  firstVariable || LogicalOperand();
            Console.WriteLine($"\n{firstVariable}");
            secondVariable = secondVariable || LogicalOperand();
            Console.WriteLine($"\n{secondVariable}");
        }
        static void Main(string[] args)
        {
            /*Exercise №1*/
            bool isTrue = true;
            bool isFalse = false;
            byte baseCache = 243;
            sbyte cacheDifference = -20;
            char theFirstLaterOfTheAlphabet = 'A';
            decimal divisor = 2;
            double squareOfPi = Math.Pow(Math.PI, 1.0 / 2);
            float half = 1 / 2;
            int minusFive = -5;
            int plusThree = 3;
            uint numberOfParts = 5;
            ulong numberOfPeopleOnEarth = 7674931131;
            long manyNegativeNumbers = -319983198313131;
            short shortMaxValue = 32767;
            ushort ushortMaxValue = 65535;
            string someString = $"Is it {isTrue} or {isFalse}?";
            object someObject = 34;
            dynamic firstDynamicVariable = 1.24;
            dynamic secondDynamicVariable = "String";

            /*Exercise №2*/
            bool flag = false;
            Console.WriteLine("1 - Increment \n2 - Decrement \n3 - Multiplication and division \n4 - Remainder \n5 - Conditional conjunction (&&) \n6 - Conditional disjunction (||) \n7 - Ternary operator \n8 - is and as operators \n9 - Explicit convertion and verbatim string literal \n0 - Exit.\n");

            do
            {
                var switchChoise = Console.ReadKey();
                switch (switchChoise.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine($"\n1 + (-5) = {Increment(minusFive)}"); // Increment
                        flag = false;
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine($"\n(-1) + 3 = {Decrement(plusThree)}"); // Decrement
                        flag = false;
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine($"\n((-5) * 3) / (-5) = {MultiplicationAndDivision(minusFive, plusThree)}"); // Multiplication and division
                        flag = false;
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine($"\n(-5) % 3 = {Remainder(minusFive, plusThree)}"); // Remainder
                        flag = false;
                        break;
                    case ConsoleKey.D5:
                        ConditionalConjunction(isFalse, isTrue); // Conditional conjunction
                        flag = false;
                        break;
                    case ConsoleKey.D6:
                        ConditionalDisjunction(isTrue, isFalse); // Conditional disjunction
                        flag = false;
                        break;
                    case ConsoleKey.D7:
                        Console.WriteLine($"\nTrue = False: {(isTrue == isFalse ? true : false)}"); // Ternary operator
                        flag = false;
                        break;
                    case ConsoleKey.D8:
                        Console.WriteLine($"\n{someObject is int}, but {someString as dynamic}"); // is and as operators
                        flag = false;
                        break;
                    case ConsoleKey.D9:
                        Console.WriteLine($"\n ushort to byte = {baseCache = (byte)ushortMaxValue}?\n" + @"(\t\b\t\n\z\q\r\t)"); // Explicit convertion and verbatim string literal
                        flag = false;
                        break;
                    case ConsoleKey.D0:
                        flag = true;
                        break;
                }
            }
            while (!flag);
        }
    }
}