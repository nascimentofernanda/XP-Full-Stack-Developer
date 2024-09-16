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
        while (!int.TryParse(Console.ReadLine(), out age)) //O TryParse converte a entrada do usuário (primeiro parâmetro) e salva na variável age (segundo parâmetro)
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
            Authorization = Console.ReadLine().Trim().ToLower(); //.Trim() remove os espaços e .ToLower() converte para minúsculas.

            //.Equals compara se a variável Authorization é igual à string yes
            //O método StringComparison.OrdinalIgnoreCase compara sem diferenciar maiúsculas de minúsculas
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