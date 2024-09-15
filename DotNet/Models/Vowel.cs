using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.Models
{
    public class Vowel
    {
        public char Letter { get; set; }

        public void Verify()
        {
            Console.WriteLine("Please type a letter:");
            char letter = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line after input

            Letter = char.ToLower(letter);

            switch (Letter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("It's a vowel.");
                    break;
                default:
                    Console.WriteLine("It's not a vowel.");
                    break;
            }
        }
    }
}