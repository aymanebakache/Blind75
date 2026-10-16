using System;
using System.Collections.Generic;
using System.Text;

namespace Blind75.Arrays_And_Hashing._07_ProductOfArrayExceptSelf
{
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int length = nums.Length;
            int[] products = new int[length];
            int right = 1, left = 1;
            for (int i = 0; i < length; i++)
            {
                products[i] = left;
                left *= nums[i];
            }
            for (int i = length - 1; i >= 0; i--)
            {
                products[i] *= right;
                right *= nums[i];
            }
            return products;
        }
    }
}
