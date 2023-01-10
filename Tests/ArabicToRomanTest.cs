using Core;

namespace Tests
{
    public class ArabicToRomanTest
    {

        [Theory]
        [InlineData(-1)]
        [InlineData(2001)]
        public void ConvertReturnsAnExceptionIfValueIsOutOfLimits(int original)
        {
            Assert.Throws<ArgumentException>(() => ArabicToRoman.Convert(original));
        }

        [Fact]
        public void ConvertReturnsTheExpectedRomanNumber()
        {
            string result = ArabicToRoman.Convert(1337);

            Assert.Equal("MCCCXXXVII", result);
        }
    }
}