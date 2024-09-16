using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.Models
{
    public class Permission
{
    public int Age { get; set; }
    public string Authorization { get; set; }

    public void CheckAge()
    {
        int age;  
        Console.WriteLine("Please enter your age:");
        while (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for your age:");
        }
        Age = age;

        if (Age >= 18)
        {
            Console.WriteLine("Entry released.");
        }
        else
        {
            Console.WriteLine("Do you have an authorization from the person responsible? Please type yes or no");
            Authorization = Console.ReadLine().Trim().ToLower();

            if (Authorization.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Entry released.");
            }
            else
            {
                Console.WriteLine("Entry prohibited.");
            }
        }
    }
}
}