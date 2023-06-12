using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendingStringMethods
{
    public static class StringSearch
    {
        public static int SearchBy(this string input, string query)
        {
            int count = 0;
            int index = 0;

            while ((index = input.IndexOf(query, index)) != -1)
            {
                index += query.Length;
                count++;
            }
            Console.WriteLine("\nSearching from: " + input + "\nSearching by string: " + query);
            return count;
        }

        public static int SearchBy(this string input, char query)
        {
            int count = 0;
            int index = 0;

            while ((index = input.IndexOf(query, index)) != -1)
            {
                index += 1;
                count++;
            }
            Console.WriteLine("\nSearching from: " + input + "\nSearching by char: " + query);
            return count;
        }
    }
}
