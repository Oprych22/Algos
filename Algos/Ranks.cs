using System.Collections.Generic;
using System.Linq;

namespace Algos
{
    public static class Ranks
    {
        public static int solution(int[] blocks) {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            var jumps = 1;

            for (var i = 0; i < blocks.Length; i++)
            {
                var counterDown = i - 1;
                var counterUp = i + 1;
                var currentJumps = 1;
                
                while (true)
                {
                    var changed = false;
                    if (counterDown >= 0 && blocks[counterDown] >= blocks[counterDown + 1])
                    {
                        currentJumps++;
                        counterDown--;
                        changed = true;
                    }

                    if (counterUp < blocks.Length && blocks[counterUp] >= blocks[counterUp - 1])
                    {
                        currentJumps++;
                        counterUp++;
                        changed = true;
                    }

                    if (!changed)
                    {
                        i = counterUp - 1;
                        break;
                    }
                }

                if (currentJumps > jumps)
                    jumps = currentJumps;
            }

            return jumps;
        }
    }
}