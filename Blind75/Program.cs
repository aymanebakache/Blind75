using Blind75.Arrays_And_Hashing;
using System.Runtime.InteropServices;

namespace Blind75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "aymane";
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            s = new string(chars);
            Console.WriteLine(Blind75.Arrays_And_Hashing.ValidAnagram.Solution.IsAnagram("racecar", "carrace"));

        }
    }
}
