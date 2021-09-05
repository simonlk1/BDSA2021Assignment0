using System;
using Xunit;

namespace leapyear.Tests
{
    public class IsLeapYearTests
    {
        [Fact]
        public void IsLeapYear_1808_is_leap_year()
        {   
            bool IsLeapYear = LeapYear.IsLeapYear(1808);

            Assert.True(IsLeapYear);
        }

        [Fact]
        public void IsLeapYear_1700_not_leap_year()
        {
            bool isLeapYear = LeapYear.IsLeapYear(1700);

            Assert.False(isLeapYear);
        }

        [Fact]
        public void IsLeapYear_1800_not_leap_year()
        {
            bool isLeapYear = LeapYear.IsLeapYear(1800);

            Assert.False(isLeapYear);
        }

        [Fact]
        public void IsLeapYear_2000_is_leap_year()
        {
            bool isLeapYear = LeapYear.IsLeapYear(2000);

            Assert.True(isLeapYear);
        }

        [Fact]
        public void IsLeapYear_1500_throws_ArgumentException()
        {
            Action action = () => LeapYear.IsLeapYear(1500);
            Assert.Throws<ArgumentException>(action);
        }
    }
}
