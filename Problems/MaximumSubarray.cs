using System;

namespace Problems
{
    public class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            int maxsum = nums[0];
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                maxsum = Math.Max(maxsum, sum);
                sum = Math.Max(sum, 0);
            }

            return maxsum;
        }
    }
}
