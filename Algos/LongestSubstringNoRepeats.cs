using System.Collections.Generic;

namespace Algos
{
    public static class LongestSubstringNoRepeats
    {
        public static int LengthOfLongestSubstring(string s) {
            var longestSubstring = 0;
            var minIndex = 0;
            var letters = new Dictionary<char, int>();
            
            for (var i = 0; i < s.Length; i++)
            {
                var currentLetter = s[i];
                if (!letters.ContainsKey(currentLetter))
                {
                    letters.Add(currentLetter, i);
                }
                else
                {
                    var index = letters[currentLetter];
                    if (minIndex <= index)
                    {
                        minIndex = index + 1;
                    }
                    letters[currentLetter] = i;
                }
                if (longestSubstring < i - minIndex + 1)
                {
                    longestSubstring = i - minIndex + 1;
                }
            }
            return longestSubstring;
        }
    }
}