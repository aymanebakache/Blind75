using Blind75.Arrays_And_Hashing;
using System.Runtime.InteropServices;
using Blind75.Arrays_And_Hashing._03_TwoSum;

namespace Blind75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] res = Blind75.Arrays_And_Hashing._03_TwoSum.Solution.TwoSum(new int[] { 2, 7, 11,15 }, 9);
            foreach (int index in res)
            {
                Console.WriteLine(  index);
            }

        }
    }
}
