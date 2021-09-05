using System;
using System.IO;
using Xunit;


/* Beware that all tests defined in this file check for an
*  exact output written to the console that is defined in the
* main method of the leapyear class. If this prompt is changed,
* the unit test will break.
*/
namespace leapyear.Tests
{
    public class MainPromptYearTests
    {
        [Fact]
        public void LeapYear_main_1502_prints_nay()
        {
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            Console.SetIn(new StringReader("1502"));
            LeapYear.Main(new string[0]);
            
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal($"Type in a year to be told whether it is a leap year:{Environment.NewLine}nay", output);
        }

        [Fact]
        public void LeapYear_main_1600_prints_yay()
        {
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            Console.SetIn(new StringReader("1600"));
            LeapYear.Main(new string[0]);
            
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal($"Type in a year to be told whether it is a leap year:{Environment.NewLine}yay", output);
        }

    }
}