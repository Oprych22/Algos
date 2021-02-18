using System;
using System.Linq;

namespace Algos
{
    public class ChineseBox
    {
        private readonly ChineseBox containedBox;

        public ChineseBox() { }

        public ChineseBox(ChineseBox containedBox)
        {
            this.containedBox = containedBox;
        }

        public int NumberOfSmallerBoxes
        {
            get
            {
                var i = 0;
                var box = this.containedBox;
                while (box != null)
                {
                    i++;
                    box = box.containedBox;

                }

                return i;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(new ChineseBox(new ChineseBox()).NumberOfSmallerBoxes);
        }
    }
    
}