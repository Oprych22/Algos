using System.Collections.Generic;
using System.Linq;

namespace Algos
{
    public static class ReduceString
    {
        public static string Reduce(string s)
        {
            var stk = new Stack<char>();
            var str = string.Empty;
        
            foreach (var c in s)
            {
                if (stk.Count > 0 && stk.Peek() == c)
                {
                    stk.Pop();
                    str = str.Remove(str.Length - 1,1);
                }
                else
                {
                    stk.Push(c);
                    str += c;
                }
            }

            return str;
        }
    }
}