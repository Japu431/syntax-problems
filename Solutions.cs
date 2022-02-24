namespace TwoSum
{
    class Solutions
    {
        public int[] TwoSum01(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }

        /*
            Accepted Runtime: 136 ms
            Your input: [2,7,11,15] = 9
            Output = [0,1]
            Expected = [0,1]
        */

        public int[] TwoSum02(int[] nums, int target)
        {
            return null;
        }
    }
}