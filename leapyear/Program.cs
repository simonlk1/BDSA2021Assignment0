using System;

namespace leapyear
{
    public class LeapYear
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ran main method of LeapYear class");
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
