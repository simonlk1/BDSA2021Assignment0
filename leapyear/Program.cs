using System;

namespace leapyear
{
    public class LeapYear
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type in a year to be told whether it is a leap year:");
            string userInput = Console.ReadLine().Trim();

            if (Int32.TryParse(userInput, out int parsedInput))
            {
                WriteLeapYear(parsedInput);
            } 
            else
            {
                Console.WriteLine("Please enter only a valid 32-bit integer and nothing else");
            }
        }
        public static void WriteLeapYear(int year){
            bool isLeapYear;
            try
            {
                isLeapYear = LeapYear.IsLeapYear(year);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                return;
            }

            if (isLeapYear) Console.WriteLine("yay");
            else            Console.WriteLine("nay"); 
        }
        public static bool IsLeapYear(int year)
        {
            if (year < 1582) throw new ArgumentException("The program only handles years 1582 and later");
            if (year % 4 != 0) return false;
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            return true;
        }
    } 
}