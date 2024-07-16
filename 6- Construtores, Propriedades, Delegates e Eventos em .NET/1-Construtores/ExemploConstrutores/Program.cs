using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        // Declarando Delegate
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            
            Matematica m = new Matematica(10, 20);
            m.Somar();

            // Operacao op = new Calculadora.Somar;
            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair;
            
            // op.Invoke(10, 10);

            // Segunda forma de chamar delegate
            // op(10, 10);

            // const double pi = 3.14;

            // Console.WriteLine(pi);

            // Data data = new Data();
            // // data.SetMes(2);

            // data.Mes = 12;
            // // Console.WriteLine(data.Mes);

            // data.ApresentarMes();
            // Aluno p1 = new Aluno("Lucas", "Ferreira", "Teste");
            // p1.Apresentar();
            // Log log = Log.GetInstance();

            // log.PropriedadeLog = "Teste instancia";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);

            // Pessoa p1 = new Pessoa("Lucas", "Ferreira");
            // p1.Apresentar();
        }
    }
}
