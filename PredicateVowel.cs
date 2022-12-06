using System;

namespace PredicateVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            var vowel = new Predicate<char>(getVowel);
            Console.WriteLine(vowel('r'));
            Console.WriteLine(vowel('a'));
            Console.WriteLine(vowel('i'));
            Console.WriteLine(vowel('s'));
        }

        static bool getVowel(char vowels)
        {
            bool getVowel = false;
            switch (char.ToLower(vowels))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    getVowel = true;
                    break;
                default:
                    break;
            }
            if (getVowel)
            {
                return true;
            }
            return false;
        }
    }

}
