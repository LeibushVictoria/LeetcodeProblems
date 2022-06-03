using Problems;
using FluentAssertions;
using Xunit;

namespace ProblemsTests
{
    public class TwoSumTests
    {
        [Fact]
        public void GetTwoSumForArray()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 26;
            int[] expectedResult = { 2, 3 };

            var solution = new TwoSum();

            int[] result = solution.FindTwoSum(nums, target);
            result.Should().Equal(expectedResult);
        }

        [Fact]
        public void GetTwoSumForArrayWithTwoElements()
        {
            int[] nums = { 2, 7 };
            int target = 9;
            int[] expectedResult = { 0, 1 };

            var solution = new TwoSum();

            int[] result = solution.FindTwoSum(nums, target);
            result.Should().Equal(expectedResult);
        }
    }
}
