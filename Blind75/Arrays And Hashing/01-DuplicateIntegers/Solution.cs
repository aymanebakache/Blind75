using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Blind75.Arrays_And_Hashing
{
    //https://neetcode.io/problems/duplicate-integer/question?list=blind75
    // Given an integer array nums, return true if any value appears more than once in the array, otherwise return false.
    public class Solution
    {
        public bool hasDuplicate(int[] nums)
        {
            HashSet<int> set = new();
            foreach (int num in nums)
            {
                if (set.Contains(num))
                    return true;
                set.Add(num);

            }
            return false;
        }
    }
}
