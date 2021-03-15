namespace Algos
{
    public static class EquilbriumPoint
    {
        public static int Solve(int[] s, int j)
        {
            if (j == 1)
                return 1;
            
            var l = 1;
            var k = s.Length - 1;
            var sum = s[0];

            while (l < k)
            {
                if (sum > 0)
                {
                    sum -= s[k];
                    k--;
                }
                else if (sum < 0)
                {
                    sum += s[l];
                    l++;
                }
                else
                {
                    break;
                }
            }
            return l + 1;
        }
        
    }
}