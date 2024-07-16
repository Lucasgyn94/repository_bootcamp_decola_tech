namespace ExemploConstrutores.Models
{
    public class Aluno : Pessoa
    {
        // Ao colocar base faz com q a classe mae tenha ciencia
        public Aluno(string nome, string sobrenome, string disciplina) : base(nome, sobrenome)
        {
            System.Console.WriteLine("Construtor classe aluno!");
        }
    }
}