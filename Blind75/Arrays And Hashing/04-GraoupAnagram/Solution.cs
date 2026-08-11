using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Blind75.Arrays_And_Hashing._04_GraoupAnagram
{
    public class Solution
    {
        public static List<List<string>> GroupAnagram(string[] str)
        {
            Dictionary<string, List<string>> Groups = new();
            int[]Frequences=new int[26];
            foreach (string Word in str)
            {
                Frequences = new int[26];
                foreach (char letter in Word)
                {
                    Frequences[letter - 'a']++;
                }
                string Key = string.Join("#", Frequences);
                if (!Groups.ContainsKey(Key))
                    Groups[Key] = new();
                Groups[Key].Add(Word);
            }
            return Groups.Values.ToList<List<string>>();
        }
    }
}
