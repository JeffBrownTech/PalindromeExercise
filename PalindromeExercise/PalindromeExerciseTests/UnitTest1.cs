using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("marshmallow", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("kayak", true)]
        [InlineData("test", false)]
        [InlineData(" ", false)]
        [InlineData("  ", false)]
        [InlineData("saippuakivikauppias", true)]  // Finnish word for "soapstone vendor"

        public void IsAPalindrome (string word, bool expected)
        {
            WordSmith wordSmith= new WordSmith();

            var actual = wordSmith.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
