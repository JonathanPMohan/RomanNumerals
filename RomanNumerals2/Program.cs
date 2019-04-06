using System;

namespace RomanNumerals2
{
    class Program
    {
        static void Main(string[] args)
        {
            startApp();
        }

        static void startApp()
        {
            Console.Title = "Roman Numerual Uno";
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;

            var convertor = new RomanNumeralConvertor();

            Console.WriteLine("Which Number Would You Like To Convert To Roman Numerals");

            // Takes Number Input to Convert To Integer //
            var input = Convert.ToInt32(Console.ReadLine());

            //Displays answer from the ConvertToRoman function on RomanNumeralConverter.cs //
            Console.WriteLine($"Solution: {convertor.ConvertToRoman(input)}");
            Console.WriteLine("Convert Another Number? (y/n)");

            // Setting user answer to a variable to read lowercase //
            var answer = Console.ReadLine().ToLower();

            // matching answer to input to exit app when anything other than y is entered //
            if (answer != "y")
            {
                Environment.Exit(-1);
            }
            startApp();
        }
    }
}