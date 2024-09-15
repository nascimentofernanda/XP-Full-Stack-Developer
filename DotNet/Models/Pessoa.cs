using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.Models
{
    public class Pessoa // Class name starts with capital letters
    {
        /* Protperties have the follow structure:
        Type of the property (public/private);
        Type of the data (int, string, etc.);
        Name of the property.
         */
        public string Nome { get; set; }
        public int Idade { get; set; }

        /* Functions have the follow structure:
        Type of the property (public/private);
        Return type. Void means the method doesn't return any value;
        Name of the method.
         */
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome}, e tenho {idade} anos.");
            // The $ is used for string interpolation.
        }
    }
}