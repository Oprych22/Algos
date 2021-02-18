using System.Collections.Generic;

namespace Algos
{
    public static class Steps
    {
        private static Dictionary<int, int> map = new Dictionary<int, int>();
        // Complete the stepPerms function below.
        public static int StepPerms(int n) {
            if(n < 0)
                return 0;

            if(n == 0)
                return 1;

            if(!map.ContainsKey(n)) {
                var count = StepPerms(n-1) + StepPerms(n-2) + StepPerms(n-3);
                map.Add(n, count);
            }
            return map[n];

        }
    }
}