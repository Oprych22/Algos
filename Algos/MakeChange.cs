using System.Collections.Generic;

namespace Algos
{
    public static class MakeChange
    {
        public static int Change(int n, List<long> c)
        {
            // int count = 0, i = 0, lastI = 0;
            // long sum = 0;
            //
            // while (true)
            // {
            //     if (i >= c.Count)
            //     {
            //         break;
            //     }
            //     
            //     var val = c[i];
            //     if (val + sum > n)
            //     {
            //         i++;
            //         continue;
            //     }
            //     
            //     sum += val;
            //
            //     if (sum == n)
            //     {
            //         count++;
            //         i = lastI;
            //         sum = 0;
            //     }
            //         
            // }
            
            var dp = new int[n+1];
            dp[0] = 1;
            for (var d = 0; d < c.Count; d++)
            {
                for (var coins = c[d]; coins <= n; coins++)
                {
                    dp[coins] += dp[coins - c[d]];
                }
            }

            return dp[n];
        }
        
    }
}