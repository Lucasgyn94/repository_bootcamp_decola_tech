using System;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario {get; set;}

        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}. Sou Professor. E ganho {Salario} por mês");
        }
    }
}