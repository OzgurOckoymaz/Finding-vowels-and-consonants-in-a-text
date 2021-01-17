using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finding_vowels_and_consonants_in_a_text
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            char[] vowel_letters = new char[0];
            char[] consonant_letters = new char[0];

            Console.WriteLine("Enter a sentence :");
            string word = Console.ReadLine();

            int counter = 0;
            while (counter < word.Length)
            {
                int a = Array.IndexOf(vowels, word[counter]);
                if (a == -1)
                {
                    Array.Resize(ref consonant_letters, consonant_letters.Length + 1);
                    consonant_letters[consonant_letters.Length - 1] = word[counter];
                }
                else
                {
                    Array.Resize(ref vowel_letters, vowel_letters.Length + 1);
                    vowel_letters[vowel_letters.Length - 1] = word[counter];
                }
                counter++;
            }

            Console.WriteLine("vowel letters in the statements are :");

            int b = 0;
            while (b < vowel_letters.Length)
            {
                Console.WriteLine(vowel_letters[b]);
                b++;
            }

            Console.WriteLine("consonant letters in the statements are :");

            int c = 0;
            while (c < consonant_letters.Length)
            {
                Console.WriteLine(consonant_letters[c]);
                c++;
            }

            Console.ReadKey();

        }
    }
}
