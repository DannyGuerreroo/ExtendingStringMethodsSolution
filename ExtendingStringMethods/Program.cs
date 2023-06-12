using System.Collections;
using System.Security.Principal;

namespace ExtendingStringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Looper = true;
            while (Looper == true) // A loop so user can keep selecting options
            {
                Console.WriteLine("\nChoose an option from the following: (Enter the number)");
                Console.WriteLine("1: Check if a string is a palindrome");
                Console.WriteLine("2: Reverse a string");
                Console.WriteLine("3: Search a string for number of occurences of a char or string");
                Console.WriteLine("4: Remove duplicate characters from a string");
                Console.WriteLine("5: Check for occurences of a character in a string");
                Console.WriteLine("6: Quit Program \n");

                char sInput = Console.ReadKey().KeyChar; // Reading user input
                Console.WriteLine("\n");

                switch (sInput) // Option selected based on user input
                {
                    case '1': // Checks if a string is a palindrome
                        Console.WriteLine("Input a string: ");
                        string palindromeInput = Console.ReadLine();
                        bool pLooper = true;
                        bool palindromeOutput = false;
                        while (pLooper == true) // A loop so user can keep selecting options
                        {
                            Console.WriteLine("\nDo you want a case-sensitive check? (1 for yes, 2 for no)");
                            char psInput = Console.ReadKey().KeyChar; // Reading user input
                            Console.WriteLine("\n");
                            switch (psInput) // Option selected based on user input
                            {
                                case '1': // User selects yes
                                    Console.WriteLine("- Doing a case-sensitive check -\n");
                                    palindromeOutput = palindromeInput.IsPalindrome(true);
                                    pLooper = false;
                                    break;
                                case '2': // User selects no
                                    Console.WriteLine("- Doing a non case-sensitive check -\n");
                                    palindromeOutput = palindromeInput.IsPalindrome();
                                    pLooper = false;
                                    break;
                                default:
                                    Console.WriteLine("Incorrect value entered, try again");
                                    break;
                            }
                        }
                        Console.WriteLine(palindromeInput + " is a Palindrome: " + palindromeOutput);
                        Console.WriteLine("\n(Press any key to continue)");
                        Console.ReadKey();
                        break;


                    case '2': // Reverses a string
                        Console.WriteLine("Input a string: ");
                        string reverseInput = Console.ReadLine();
                        bool rLooper = true;
                        string reverseOutput = "";
                        while (rLooper == true) // A loop so user can keep selecting options
                        {
                            Console.WriteLine("\nDo you want the casing to remain in the same position? (1 for yes, 2 for no)");
                            char rsInput = Console.ReadKey().KeyChar; // Reading user input
                            Console.WriteLine("\n");

                            switch (rsInput) // Option selected based on user input
                            {
                                case '1': // User selects yes
                                    rLooper = false;
                                    reverseOutput = reverseInput.ReverseInput(true);
                                    break;
                                case '2': // User selects no
                                    rLooper = false;
                                    reverseOutput = reverseInput.ReverseInput();
                                    break;
                                default:
                                    Console.WriteLine("Incorrect value entered, try again");
                                    break;

                            }
                        }
                        Console.WriteLine(reverseOutput);
                        Console.WriteLine("\n(Press any key to continue)");
                        Console.ReadKey();
                        break;


                    case '3': // Searches a string
                        Console.WriteLine("Input a string you would like to search from: ");
                        string searchInput = Console.ReadLine();
                        bool sLooper = true;
                        int searchOutput = -1;
                        while (sLooper == true) // A loop so user can keep selecting options
                        {
                            Console.WriteLine("\nDo you want to search by a char or string? (1 for char, 2 for string)");
                            char ssInput = Console.ReadKey().KeyChar; // Reading user input
                            Console.WriteLine("\n");

                            switch (ssInput) // Option selected based on user input
                            {
                                case '1': // User selects char
                                    sLooper = false;
                                    Console.WriteLine("Please input the char you would like to search by: ");
                                    char charInput = Console.ReadKey().KeyChar;
                                    searchOutput = searchInput.SearchBy(charInput);
                                    break;
                                case '2': // User selects string
                                    sLooper = false;
                                    Console.WriteLine("Please input the string you would like to search by: ");
                                    string stringInput = Console.ReadLine();
                                    searchOutput = searchInput.SearchBy(stringInput);
                                    break;
                                default:
                                    Console.WriteLine("Incorrect value entered, try again");
                                    break;

                            }
                        }
                        Console.WriteLine("\n# of occurences: " + searchOutput);
                        Console.WriteLine("\n(Press any key to continue)");
                        Console.ReadKey();
                        break;


                    case '4': // Removes duplicates from a string
                        Console.WriteLine("Input a string you would like to remove duplicate characters from: ");
                        string dupeInput = Console.ReadLine();
                        string dupeOutput = dupeInput.RemoveDuplicates();
                        Console.WriteLine("Inputted string: " + dupeInput +
                            "\nConverted string (duplicate chars removed): " + dupeOutput);
                        Console.WriteLine("\n(Press any key to continue)");
                        Console.ReadKey();
                        break;


                    case '5': // Checks occurrences from a string
                        Console.WriteLine("Input a string you would like to get the occurrences of a char from: ");
                        string occurrenceInput = Console.ReadLine();
                        bool oLooper = true;
                        int occurrenceOutput = -1;
                        while (oLooper == true) // A loop so user can keep selecting options
                        {
                            Console.WriteLine("\nChoose a type of occurrence to gather:\n" +
                                "1: Max Occurrence\n" +
                                "2: Min Occurrence\n" +
                                "3: Max Occurrence of Vowels only\n" +
                                "4: Min Occurrence of Vowels only\n" +
                                "(Type the number to select your choice)");
                            char osInput = Console.ReadKey().KeyChar; // Reading user input
                            Console.WriteLine("\n");

                            switch (osInput) // Option selected based on user input
                            {
                                case '1': // User selects max
                                    Console.WriteLine("Getting the max occurrence from: " + occurrenceInput);
                                    oLooper = false;
                                    occurrenceOutput = occurrenceInput.MaxOccurrence();
                                    break;
                                case '2': // User selects min
                                    Console.WriteLine("Getting the min occurrence from: " + occurrenceInput);
                                    oLooper = false;
                                    occurrenceOutput = occurrenceInput.MinOccurrence();
                                    break;
                                case '3': // User selects max vowels
                                    Console.WriteLine("Getting the max occurrence of vowels from: " + occurrenceInput);
                                    oLooper = false;
                                    occurrenceOutput = occurrenceInput.MaxOccurrence(Occurrences.OccurrenceType.MaxVowels);
                                    break;
                                case '4': // User selects min vowels
                                    Console.WriteLine("Getting the min occurrence of vowels from: " + occurrenceInput);
                                    oLooper = false;
                                    occurrenceOutput = occurrenceInput.MinOccurrence(Occurrences.OccurrenceType.MinVowels);
                                    break;
                                default:
                                    Console.WriteLine("Incorrect value entered, try again");
                                    break;
                            }
                        }
                        Console.WriteLine("Occurrences: " + occurrenceOutput);
                        Console.WriteLine("\n(Press any key to continue)");
                        Console.ReadKey();
                        break;


                    case '6': // Stops the loop and program
                        Console.WriteLine("Thanks for using the StringMethods app, Goodbye.");
                        Looper = false;
                        break;
                    default: // In case user inputs incorrect value, tells them to retry
                        Console.WriteLine("Incorrect Value Error: Please try again.\n");
                        break;
                }
            }
        }
    }
}