using Ingenico.CodingDojo.RomanNumerals;
using Xunit;

namespace Ingenico.CodingDojo.RomanNumerals.Tests
{
    public class RomanNumberTests
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(3, "III")]
        [InlineData(10, "X")]
        [InlineData(14, "XIV")]
        [InlineData(49, "XLIX")]
        [InlineData(50, "L")]
        [InlineData(555, "DLV")]
        [InlineData(666, "DCLXVI")]
        [InlineData(250, "CCL")]
        [InlineData(251, "CCLI")]
        [InlineData(399, "CCCXCIX")]
        [InlineData(405, "CDV")]
        [InlineData(400, "CD")]
        [InlineData(51, "LI")]
        [InlineData(1000, "M")]
        [InlineData(2000, "MM")]
        [InlineData(3000, "MMM")]
        [InlineData(3333, "MMMCCCXXXIII")]
        [InlineData(30000, "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMM")]
        public void SendNumberReturnsRoman(int number, string expectedResult)
        {
            // Arrange 
            var romanNumber = new RomanNumber();

            // Act 
            var result = romanNumber.Convert(number);

            // Arrange 
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(0, "")]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        public void RomanLineTestSmallUnit(int number, string expectedResult)
        {
            // Arrange 
            var romanNumber = new RomanNumberSectionLetter('I', 'V', 'X');

            // Act 
            var result = romanNumber.Convert(number);

            // Arrange 
            Assert.Equal(expectedResult, result);
        }
    }
}
