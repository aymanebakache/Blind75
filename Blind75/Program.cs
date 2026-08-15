using Blind75.Arrays_And_Hashing;
using System.Runtime.InteropServices;
using Blind75.Arrays_And_Hashing._03_TwoSum;

namespace Blind75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 7,7 };
            int k = 1;
            int[] res = Blind75.Arrays_And_Hashing._05_TopKFrequentElements.Solution.TopKFrequent(nums, k);
            foreach(int num in res)
                Console.WriteLine(num);

        }
    }
}
