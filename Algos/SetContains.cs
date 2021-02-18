using System;
using System.Collections.Generic;
using System.Linq;

namespace Algos
{
    public static class SetContains
    {
        public static int solution(string S, int[] X, int[] Y)
        {
            var graphMap = new Dictionary<int, char>();
            var countedMap = new HashSet<char>();
            var furthestDistance = 0;

            for (var i = 0; i < X.Length; i++)
            {
                var x = Math.Abs(X[i]);
                var y = Math.Abs(Y[i]);
                var n = (x * x) + (y * y);
                graphMap.Add(n, S[i]);
                if (x > furthestDistance)
                    furthestDistance = x;
                if (y > furthestDistance)
                    furthestDistance = y;

            }

            for (var i = 0; i <= furthestDistance; i++)
            {
                var n = (i * i) * 2;
                var graph = graphMap.Where(x => x.Key < n).ToList();
                if ((countedMap.SetEquals(graph.Select(x => x.Value).ToList()) && countedMap.Count > 0) || graph.Select(x => x.Value).GroupBy(j => j).Any(g => Enumerable.Count<char>(g) > 1))
                {
                    return countedMap.Count();
                }
                foreach (var point in graphMap.Where(x => x.Key < n))
                {
                    countedMap.Add(point.Value);
                }
            }

            return 0;
        }
    }
}