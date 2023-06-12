using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendingStringMethods
{
    public static class Occurrences
    {
        public static int MaxOccurrence(this string input)
        {
            var charCounts = input.GroupBy(c => c)
                .ToDictionary(g => g.Key, g => g.Count());

            int maxCount = charCounts.Values.Max();

            char maxChar = charCounts.OrderByDescending(kv => kv.Value)
            .FirstOrDefault().Key;
            Console.WriteLine("The maximum char found: " + maxChar.ToString());

            return maxCount;
        }

        public static int MinOccurrence(this string input)
        {
            var charCounts = input.GroupBy(c => c)
                .ToDictionary(g => g.Key, g => g.Count());

            int minCount = charCounts.Values.Min();

            char minChar = charCounts.OrderBy(kv => kv.Value)
            .FirstOrDefault().Key;
            Console.WriteLine("The minimum char found: " + minChar.ToString());

            return minCount;
        }

        public static int MaxOccurrence(this string input, OccurrenceType otype)
        {
            if (otype == OccurrenceType.MaxVowels)
            {
                var vowels = "aeiouAEIOU";

                var charCounts = input.Where(c => vowels.Contains(c))
                    .GroupBy(c => c)
                    .ToDictionary(g => g.Key, g => g.Count());

                //if (charCounts.Count == 0)
                //    return 0;

                int maxCount = charCounts.Values.Max();

                char maxChar = charCounts.OrderByDescending(kv => kv.Value)
                    .FirstOrDefault().Key;
                Console.WriteLine("The maximum vowel char found: " + maxChar.ToString());

                return maxCount;
            }
            else
            {
                return input.MaxOccurrence();
            }
        }

        public static int MinOccurrence(this string input, OccurrenceType otype)
        {
            if(otype == OccurrenceType.MinVowels)
            {
                var vowels = "aeiouAEIOU";

                var charCounts = input.Where(c => vowels.Contains(c))
                    .GroupBy(c => c)
                    .ToDictionary(g => g.Key, g => g.Count());

                //if (charCounts.Count == 0)
                //    return 0;

                int minCount = charCounts.Values.Min();

                char minChar = charCounts.OrderBy(kv => kv.Value)
                    .FirstOrDefault().Key;
                Console.WriteLine("The minimum vowel char found: " + minChar.ToString());

                return minCount;
            }
            else
            {
                return input.MinOccurrence();
            }
        }

        public enum OccurrenceType
        {
            Max,
            Min,
            MaxVowels,
            MinVowels
        }
    }
}
