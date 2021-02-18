using System.Collections.Generic;

namespace Algos
{
    public static class CountTriplets
    {
        public static long countTriplets(List<long> arr, long r)
        {
            int[] countArr = new int[r];
            long s = 0;
            int counter = 0;
            for (var i = 0; i < arr.Count; i++)
            {
                if (s != arr[i])
                {
                    s = arr[i];
                    counter += 1;
                }

                countArr[counter]++;
            }

            return r;
        }
    }
}