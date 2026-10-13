using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Blind75.Arrays_And_Hashing.EncodeAndDecodeString
{
    public class Solution
    {
        public static string Encode(IList<string> strs)
        {
            StringBuilder encoded = new StringBuilder("");
            foreach (string str in strs)
            {
                encoded.Append(str.Length)
                       .Append("#")
                       .Append(str);
            }
            return encoded.ToString();
        }

        public static List<string> Decode(string coded)
        {
            int index = 0;
            List<string> decodedStrings = new List<string>();
            while (coded.Length > index)
            {

                int indexOfSeperator = coded.IndexOf("#", index);
                int lengthOfWord = int.Parse(coded.Substring(index, indexOfSeperator - index));
                string word = coded.Substring(indexOfSeperator + 1, lengthOfWord);
                decodedStrings.Add(word);
                index = indexOfSeperator + lengthOfWord + 1;
            }
            return decodedStrings;
        }
    }
}
