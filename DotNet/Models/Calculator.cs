using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.Models
{
    public class Calculator
    {
        public void Add(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x+y}");
        }

        public void Subtract(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x-y}");
        }

        public void Multiply(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x*y}");
        }

        public void ToDivide(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x/y}");
        }
    }
}