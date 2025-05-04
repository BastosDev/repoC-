using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repoC_.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Nome = "Gustavo";
            Idade = 19;
            Console.WriteLine($"Meu nome é {Nome} e minha idade é {Idade}.");

        }
    }
}