using Xunit;

namespace t0.Tests
{
    public class FactorialTests
    {
        [Fact]
        public void Factorial_Zero_ReturnsOne()
        {
            Assert.Equal(1, Exercises.Factorial(0));
        }

        [Fact]
        public void Factorial_One_ReturnsOne()
        {
            Assert.Equal(1, Exercises.Factorial(1));
        }

        [Fact]
        public void Factorial_Five_Returns120()
        {
            Assert.Equal(120, Exercises.Factorial(5));
        }

        [Fact]
        public void Factorial_Ten_Returns3628800()
        {
            Assert.Equal(3628800, Exercises.Factorial(10));
        }
    }

    public class ReverseStringTests
    {
        [Fact]
        public void ReverseString_Hello_ReturnsOlleh()
        {
            Assert.Equal("olleh", Exercises.ReverseString("hello"));
        }

        [Fact]
        public void ReverseString_SingleChar_ReturnsSameChar()
        {
            Assert.Equal("a", Exercises.ReverseString("a"));
        }

        [Fact]
        public void ReverseString_EmptyString_ReturnsEmpty()
        {
            Assert.Equal("", Exercises.ReverseString(""));
        }

        [Fact]
        public void ReverseString_Palindrome_ReturnsSameString()
        {
            Assert.Equal("saippuakauppias", Exercises.ReverseString("saippuakauppias"));
        }
    }

    public class CountVowelsTests
    {
        [Fact]
        public void CountVowels_Programming_Returns3()
        {
            Assert.Equal(3, Exercises.CountVowels("programming"));
        }

        [Fact]
        public void CountVowels_AEIOU_Returns5()
        {
            Assert.Equal(5, Exercises.CountVowels("AEIOU"));
        }

        [Fact]
        public void CountVowels_NoVowels_ReturnsZero()
        {
            Assert.Equal(0, Exercises.CountVowels("rhythm"));
        }

        [Fact]
        public void CountVowels_MixedCase_CountsBoth()
        {
            Assert.Equal(3, Exercises.CountVowels("HeLLo"));
        }
    }
}
