using Problems;
using FluentAssertions;
using Xunit;

namespace ProblemsTests
{
    public class PalindromeNumberTests
    {
        [Fact]
        public void CheckNumberIsPolindromePositive()
        {
            int x = 121;

            var solution = new PalindromeNumber();

            bool result = solution.IsPalindrome(x);
            result.Should().BeTrue();
        }

        [Fact]
        public void CheckNumberIsPolindromeNegative()
        {
            int x = 12345;

            var solution = new PalindromeNumber();

            bool result = solution.IsPalindrome(x);
            result.Should().BeFalse();
        }
    }
}
