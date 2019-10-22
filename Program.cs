using System;

namespace PigLatin2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;

            Console.WriteLine("Welcome to the Pig Latin Translator!");
            Console.WriteLine();

            while (keepGoing == true)
            {
                Console.Write("Enter a line to be translated: ");
                string phrase = Console.ReadLine();
                string output = ToPigLatin2(phrase);
                Console.WriteLine();
                Console.WriteLine($"New word: {output}");
                Console.WriteLine();

                Console.Write("Translate another line? (y/n)");
                string doOver = Console.ReadLine();
                Console.WriteLine();

                if (doOver.ToLower().Equals("y"))
                {
                    keepGoing = true;
                }
                else
                {
                    keepGoing = false;
                }

            }

        }
        public static string ToPigLatin2(string word)
        {
            string[] words = word.Split(' ');
            word = string.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= 1) continue;
                string output = new String(words[i].ToCharArray());
                output = output.Substring(1, output.Length - 1) + output.Substring(0, 1) + "ay ";
                word += output;
                
            }
            return word;
        }

        // This method was close to being right but could you still give me feedback on this?  
        // I feel like it's soo close but not quite there.
        public static string ToPigLatin(string word)
        {
            string vowels = "AEIOUaeio";
            string newWord = " ";

            foreach (string vowel in word.Split(' '))
            {
                string firstLetter = word.Substring(0, 1);

                string restOfWord = word.Substring(1, word.Length - 1);
                int currentLetter = vowels.IndexOf(firstLetter);

                if (currentLetter == -1)
                {
                    newWord = restOfWord + firstLetter + "ay";
                }
                else
                {
                    newWord = word + restOfWord + "way";
                }
            }
            return newWord;
        }

        
        

    }
}
