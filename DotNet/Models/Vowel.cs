using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.Models
{
    public class Vowel
    {
        public void Verify()
        {
            Console.WriteLine("Please type a letter:");
            char letter = char.ToLower(Console.ReadKey().KeyChar); // Receives the letter and converts it to lowercase
            Console.WriteLine(); // Move to the next line after input

            switch (letter)
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