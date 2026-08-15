using System;
using System.Collections.Generic;
using System.Text;

namespace Blind75.Arrays_And_Hashing._05_TopKFrequentElements
{
    public class Solution
    {
        
        public static int[] TopKFrequent(int[]nums,int K)
        {
            Dictionary<int, int> Frequencies = new();
            foreach (int num in nums)
            {
                if (!Frequencies.ContainsKey(num))
                    Frequencies[num] = 0;
                Frequencies[num]++;
            }
            List<int>[] Bucket = new List<int>[nums.Length + 1];
            foreach(var pair in Frequencies)
            {
                int num = pair.Key;
                int Frequecy = pair.Value;
                if (Bucket[Frequecy] == null)
                    Bucket[Frequecy] = new();
                Bucket[Frequecy].Add(num);
            }
            int[] Results = new int[K];
            int ResultIndex = 0;
            for (int i = nums.Length; i >=1&&ResultIndex<K ; i--)
            {
                if (Bucket[i] == null)
                    continue;
                foreach (int num in Bucket[i])
                {
                    Results[ResultIndex++] = num;
                    if (ResultIndex == K)
                        return Results;
                }
            }
            return Results;
        }
    }
}
