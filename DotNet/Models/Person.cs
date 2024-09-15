using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.Models //Project pathway
{
    public class Person // Class name starts with capital letters
    {
        /* Protperties have the follow structure:
        Type of the property (public/private);
        Type of the data (int, string, etc.);
        Name of the property.
         */
        public string Name { get; set; }
        public int Age { get; set; }

        /* Functions have the follow structure:
        Type of the property (public/private);
        Return type. Void means the method doesn't return any value;
        Name of the method.
         */
        public void Present()
        {
            Console.WriteLine($"Hello, my name is {name} and I'm {age} years old.");
            // The $ is used for string interpolation.
        }
    }
}