using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendingStringMethods
{
    public static class StringReverse
    {
        public static string ReverseInput(this string input)
        {
            char[] characters = input.ToCharArray();
            Array.Reverse(characters);
            Console.WriteLine("Inputted string:\n" + input);
            Console.WriteLine("Reversed string: ");
            return new string(characters);
        }

        public static string ReverseInput(this string input, bool keepPosition)
        {
            char[] characters = input.ToCharArray();
            Array.Reverse(characters);

            if (keepPosition)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsUpper(input[i]))
                        characters[i] = char.ToUpper(characters[i]);
                    else
                        characters[i] = char.ToLower(characters[i]);
                }
            }
            Console.WriteLine("Inputted string:\n" + input);
            Console.WriteLine("Reversed string with original casing positions: ");
            return new string(characters);
        }
    }
}
