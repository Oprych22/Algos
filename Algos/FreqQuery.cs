using System;
using System.Collections.Generic;

namespace Algos
{
    public static class FreqQuery
    {
        public static List<int> freqQuery(List<List<int>> queries)
        {
            var outPut = new List<int>();
            var dict = new Dictionary<int, int>();
            foreach (var query in queries)
            {
                var action = query[0];
                var value = query[1];

                if (action == 1)
                {
                    if (!dict.ContainsKey(value))
                    {
                        dict.Add(value, 1);
                    }
                    else 
                    {
                        dict[value]++;
                    }
                }
                if (action == 2)
                {
                    if (dict.ContainsKey(value))
                    {
                        dict[value]--;
                        if (dict[value] <= 0)
                        {
                            dict.Remove(value);
                        }
                    }
                }
                if (action == 3)
                {
                    var outQuery = 0;
                    foreach (var keyVal in dict)
                    {
                        if (keyVal.Value == value)
                        {
                            outQuery = 1;
                            break;
                        }

                    }
                    Console.Out.WriteLine(outQuery);
                    outPut.Add(outQuery);
                }

            }

            return outPut;

        }
    }
}