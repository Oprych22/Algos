using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "Hello".ToLower();
            var s2 = "World".ToLower();
            int[] arr = new int[26];
            string st = "";
            foreach(var c in s1)
            {
                arr[(int)c - (int)'a'] = 1;
            }
        
            foreach (var c in s2)
            {
                if (arr[(int)c - (int)'a'] == 1)
                    st = "Yes";
            }
            st = "No";
        }
    }
}
