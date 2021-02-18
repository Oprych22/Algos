using System.Linq;

namespace Algos
{
    public static class Anagram
    {
        public static bool IsAnagram(string s1, string s2)
        {
            var arr = new int[26];

            if (s1.Length != s2.Length)
                return false;
            foreach(var c in s1.ToLower())
            {
                arr[(int)c - (int)'a']++;
            }

            return s2.ToLower().All(c => arr[(int) c - (int) 'a']-- > -1);
        }
    }
}