using System;
using System.Collections.Generic;
using System.Linq;
using Algos.Tree;

namespace Algos
{
    public static class MaxDepthSearch
    {   
        public static int MaxDepth(Node root)
        {

            if (root is null)
                return -1;
            
            var lDepth = MaxDepth(root.left); 
            var rDepth = MaxDepth(root.right);

            return 1 + Math.Max(lDepth, rDepth);
        }
    }
}