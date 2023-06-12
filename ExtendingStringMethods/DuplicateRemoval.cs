using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendingStringMethods
{
    public static class DuplicateRemoval
    {
        public static string RemoveDuplicates(this string input)
        {
            StringBuilder output = new StringBuilder();
            bool[] dupes = new bool[char.MaxValue];

            foreach (char c in input)
            {
                if (!dupes[c])
                {
                    output.Append(c);
                    dupes[c] = true;
                }
            }
            return output.ToString();
        }
    }
}
