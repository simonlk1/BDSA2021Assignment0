using System;
using Xunit;
using leapyear;

namespace leapyear.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void IsLeapYear_400_divisible_by_4()
        {
            //Arrange
            LeapYear leapyear = new LeapYear();

            //Act
            bool IsLeapYear = leapyear.IsLeapYear(400);

            //Assert
            Assert.True(IsLeapYear);
        }

        [Fact]
        public void IsLeapYear_1700_not_leap_year()
        {
            LeapYear leapyear = new LeapYear();

            bool isLeapYear = leapyear.IsLeapYear(1700);

            Assert.False(isLeapYear);
        }

        [Fact]
        public void IsLeapYear_1800_not_leap_year()
        {
            LeapYear leapyear = new LeapYear();

            bool isLeapYear = leapyear.IsLeapYear(1800);

            Assert.False(isLeapYear);
        }

        [Fact]
        public void IsLeapYear_2000_is_leap_year()
        {
            LeapYear leapyear = new LeapYear();

            bool isLeapYear = leapyear.IsLeapYear(2000);

            Assert.True(isLeapYear);
        }
    }
}
