namespace TwoSum.bugs
{
    class Solution01
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { };
        }
        /*
            Accepted Runtime: 136 ms
            Your input: [2,7,11,15] = 9
            Output = [0,1]
            Expected = [0,1]
        */
    }
}