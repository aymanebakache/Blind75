using System;
using System.Collections.Generic;
using System.Text;

namespace Blind75.Arrays_And_Hashing.ValidAnagram
{
    public class Solution
    {
        public static bool IsAnagram(string S,string T)
        {
            char[] chars1 = S.ToCharArray();
            char[] chars2 = T.ToCharArray();
            Array.Sort(chars1);
            Array.Sort(chars2);
            S = new string(chars1);
            T = new string(chars2);
            return S == T;
        }
        public static bool IsAnagramV2(string S,string T)
        {
            if (S.Length != T.Length)
                return false;
            int[] Frequences = new int[26];
            for (int i = 0; i < S.Length; i++)
            {
                Frequences[S[i] - 'a']++;
                Frequences[T[i] - 'a']--;
            }
            for(int i=0;i<26;i++)
            {
                if (Frequences[i] != 0)
                    return false;
            }
            return true;
        }
    }
}
