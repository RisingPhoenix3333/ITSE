using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        public static void Main(string[] args)
        {

         pig();

         Console.ReadKey();
        }
        public static void pig()
        {
            Console.WriteLine("Please enter a word");

            string word = Console.ReadLine();

            word = word.ToLower();

            string[] vowels = { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U"};

            char[] vowels2 = { 'a', 'e', 'i', 'o', 'u' };

            string firstletter = word.Substring(0, 1);
            
            string lastletter = word.Substring(word.Length - 1);

            if (vowels.Contains(firstletter) && vowels.Contains(lastletter)) {
                Console.WriteLine(word + "yay");
            }

            else if (vowels.Contains(firstletter) && !vowels.Contains(lastletter);
            {
                Console.WriteLine(word + "ay");
            }

            else if (word.IndexOfAny(vowels2) == -1)
            {
                Console.WriteLine(word + "ay");
            }

            else if (word.IndexOfAny(vowels2)  > -1 && !vowels.Contains(firstletter))
            {
                string before = word.Substring(0, word.IndexOfAny(vowels2));

                string after = word.Substring(word.IndexOfAny(vowels2));

                Console.WriteLine(after + before + "ay");
            }

            



           


            
        }
    }
}
