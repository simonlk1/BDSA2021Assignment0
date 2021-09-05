using System;

namespace leapyear
{
    public class LeapYear
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type in a year to be told whether it is a leap year:");
            string userInput = Console.ReadLine().Trim();
            int parsedInput = Int32.Parse(userInput);

            LeapYear leapYear = new LeapYear();
            bool isLeapYear = leapYear.IsLeapYear(parsedInput);
            
            if (isLeapYear) Console.WriteLine("yay");
            else            Console.WriteLine("nay"); 
        }
        public bool IsLeapYear(int year)
        {
            if (year % 4 != 0) return false;
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            return true;
        }
    } 
}