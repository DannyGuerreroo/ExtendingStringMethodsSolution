using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendingStringMethods
{
    public static class PalindromeCheck
    {
        public static bool IsPalindrome(this string input)
        {
                var reversed = input.ToLower().Reverse().ToArray();
                String reverse = new String(reversed);
                Console.WriteLine("Inputted string: " + input);
                Console.WriteLine("Converted input: " + input.ToLower());
                Console.WriteLine("Outputted string: " + reverse);
                bool isEqual = (reverse == input.ToLower());
                return isEqual;
        }

        public static bool IsPalindrome(this string input, bool sensitive)
        {
            if(sensitive)
            {
                var reversed = input.Reverse().ToArray();
                String reverse = new String(reversed);
                Console.WriteLine("Inputted string: " + input);
                Console.WriteLine("Converted string: " + reverse);
                bool isEqual = (reverse == input);
                return isEqual;
            }
            else
            {
                return IsPalindrome(input);
            }
        }
    }
}
