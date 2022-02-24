using System;
using System.Linq;
using System.Collections;

namespace TwoSum.bugs
{
    public class Solution02
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //Quando você precisar procurar itens em uma coleção pela chave , você usa Hashtable();
            var numbers = new Hashtable();

            for (var i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (numbers.ContainsKey(complement))
                    return new int[] { (int)numbers[complement], i };

                if (!numbers.ContainsKey(nums[i]))
                    numbers.Add(nums[i], i);
            }

            return new int[] { };
        }
    }
    /*
       Accepted
       Runtime: 208 ms
       Your input: [2,7,11,15] =  9
       Output: [0,1]
       Expected: [0,1]
    */
}