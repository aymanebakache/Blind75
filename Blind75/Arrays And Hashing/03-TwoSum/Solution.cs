using System;
using System.Collections.Generic;
using System.Text;

namespace Blind75.Arrays_And_Hashing._03_TwoSum
{
    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> Indexes = new();
            for (int i = 0; i < nums.Length; i++)
            {
                int Complement = target - nums[i];
                if (Indexes.ContainsKey(Complement))
                    return new int[] { Indexes[Complement], i };
                Indexes[nums[i]] = i;
            }
            return Array.Empty<int>();
        }
    }

}
