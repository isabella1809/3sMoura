using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Pessoa
    {
        
            public string Nome;
            public int Idade;
    }

    class Program
{
    static void Main()
    {
      Pessoa p1 = new Pessoa();
        p1.Nome = "Ana";
        p1.Idade = 20;

        Console.WriteLine($"Nome: {p1.Nome}");
        Console.WriteLine($"Idade: {p1.Idade}");
    }
}
}