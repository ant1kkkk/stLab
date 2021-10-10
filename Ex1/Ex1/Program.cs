using System;

namespace Ex01
{
    class Program
    {
        static int Increment(int variable) // Метод, который возвращает число после выполнения оператора префиксного инкремента
        {
            return ++variable;
        }
        static int Decrement(int variable) // Метод, который возвращает число после выполнения оператора префиксного декремента
        {
            return --variable;
        }
        static double MultiplicationAndDivision(int firstVariable, int secondVariable) // Метод, который возвращает число после умножения и деления
        {
            return (firstVariable * secondVariable) / firstVariable;
        }
        static int Remainder(int firstVariable, int secondVariable) // Метод, возвращающий остаток от деления двух чисел
        {
            return Math.Abs(firstVariable % secondVariable);
        }
        static bool ConditionalConjunction(bool firstVariable, bool secondVariable) // Метод, выполняющий конъюнкцию
        {
            if ((firstVariable && secondVariable) != true)
            {
                return secondVariable;
            }
            else
            {
                return false;
            }
        }
        static bool LogicalOperand()
        {
            return true;
        }
        static void Main(string[] args)
        {
            /*Задание №1*/
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

            /*Задание №2*/
            bool flag = false;
            Console.WriteLine("1 - Инкремент \n2 - Декремент \n3 - Умножение и деление \n4 - Остаток от деления \n5 - Условное И \n6 - Условное ИЛИ \n7 - Тернарный условный оператор \n8 - Операторы is и as \n9 - Явное преобразование типов и буквальный строковый литерал \n0 - Выход.\n");

            do
            {
                var switchChoise = Console.ReadKey();
                switch (switchChoise.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine($"\n1 + (-5) = {Increment(minusFive)}"); // Инкремент
                        flag = false;
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine($"\n(-1) + 3 = {Decrement(plusThree)}"); // Декремент
                        flag = false;
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine($"\n((-5) * 3) / (-5) = {MultiplicationAndDivision(minusFive, plusThree)}"); // Умножение и деление
                        flag = false;
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine($"\n(-5) % 3 = {Remainder(minusFive, plusThree)}"); // Остаток от деления
                        flag = false;
                        break;
                    case ConsoleKey.D5:
                        Console.WriteLine($"\nFalse && True = {ConditionalConjunction(isFalse, isTrue)}"); // Условное И
                        flag = false;
                        break;
                    case ConsoleKey.D6:
                        Console.WriteLine($"\nTrue || False = {isTrue || LogicalOperand()} \nFalse || True = {isFalse || LogicalOperand()}"); // Условное ИЛИ
                        flag = false;
                        break;
                    case ConsoleKey.D7:
                        Console.WriteLine($"\nTrue = False: {(isTrue == isFalse ? true : false)}"); // Тернарный условный оператор
                        flag = false;
                        break;
                    case ConsoleKey.D8:
                        Console.WriteLine($"\n{someObject is int}, but {someString as dynamic}"); // Операторы is и as
                        flag = false;
                        break;
                    case ConsoleKey.D9:
                        Console.WriteLine($"\n ushort to byte = {baseCache = (byte)ushortMaxValue}?\n" + @"(\t\b\t\n\z\q\r\t)"); // Явное преобразование типов и буквальный строковый литерал
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