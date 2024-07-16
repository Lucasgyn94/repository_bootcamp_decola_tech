namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota {get; set;}

        public override void Apresentar()
        {
            System.Console.WriteLine($"Meu nome é {Nome}. Sou aluno de Nota {Nota}");
        }
    }
}