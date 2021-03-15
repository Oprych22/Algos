namespace Algos
{
    public static class SmallestSubsetGreaterThanK
    {
        public static int Solve(int[] arr, int k)
        {
            var lowestSubset = int.MaxValue;
            var sum = 0;
            var lowestIndex = 0;
            var HighestIndex = 0;
            var offset = 0;
            while (lowestIndex < arr.Length-1)
            {
                if (HighestIndex == arr.Length)
                {
                    offset = 1;
                    if (sum <= k)
                    {
                        sum -= arr[lowestIndex];
                        lowestIndex++;
                    }
                    else
                    {
                        return lowestSubset;
                    }
                    
                }
                else
                {

                    if (arr[HighestIndex] >= k)
                        return 1;

                    if (sum >= k)
                    {
                        sum -= arr[lowestIndex];
                        lowestIndex++;
                    }
                    else
                    {
                        sum += arr[HighestIndex];
                        HighestIndex++;
                    }
                }
                
                
                if (lowestSubset > HighestIndex- offset- lowestIndex && sum >= k)
                {
                    lowestSubset = HighestIndex - offset - lowestIndex;
                }


            }

            return lowestSubset;
        }
        
    }
}