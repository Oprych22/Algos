namespace Algos
{
    public static class KthElementTwoSortedArrays
    {
        public static int Solve(int[] a, int[] b, int k)
        {
            var i = 0;
            var j = 0;
            var sum = 0;
            while (i + j < k)
            {
                if (a[i] <= b[j])
                {
                    sum = a[i];
                    i++;
                }
                else
                {
                    sum = b[j];
                    j++;
                }
            }

            return sum;

        }
    }
}