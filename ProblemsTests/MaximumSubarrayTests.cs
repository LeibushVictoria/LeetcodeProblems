using Problems;
using FluentAssertions;
using Xunit;

namespace ProblemsTests
{
    public class MaximumSubarrayTests
    {
        [Fact]
        public void GetMaxSumFromArray()
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            var solution = new MaximumSubarray();

            int result = solution.MaxSubArray(nums);
            result.Should().Be(6);
        }

        [Fact]
        public void GetMaxSumFromArrayWithOnlyMinusNumbers()
        {
            int[] nums = { -2, -11, -3, -4, -1, -12, -5, -24 };

            var solution = new MaximumSubarray();

            int result = solution.MaxSubArray(nums);
            result.Should().Be(-1);
        }

        [Fact]
        public void GetMaxSumFromArrayWithOneNumbers()
        {
            int[] nums = { 5 };

            var solution = new MaximumSubarray();

            int result = solution.MaxSubArray(nums);
            result.Should().Be(5);
        }
    }
}
