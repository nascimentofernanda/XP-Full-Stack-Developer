using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.Models
{
    public class Calculator
    {
        public Void add(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x+y}");
        }

        public Void subtract(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x-y}");
        }

        public Void multiply(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x*y}");
        }

        public Void add(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x/y}");
        }
    }
}